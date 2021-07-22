loadData();

function loadData() {
    fetch(`/Cart/GetListItems`, {
    })
        .then(response => response.json())
        .then(data => {
            console.log('get list:', data);
            let html = ''
            let total = 0

            for (var i = 0; i < data.length; i++) {
                let item = data[i]
                let amount = item.price * item.quantity;
                let address = document.getElementById('hidBaseAddress').value;
                html += `<tr id = "item_${item.productId}">
                                    <td>
                                        <div class="table__content">
                                            <div class="table__content-thumb">
                                                <img src="${address + item.image
                    } " alt=""
                                                     class="table__content-img img-responsive">
                                            </div>
                                            <a href="/product/${item.productId}" class="table__content-name">
                                                ${item.name}
                                            </a>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="table__content">
                                            <p class="table__content-price"> ${(item.price)}$</p>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="table__content">
                                            <div class="section__quantity">
                                                <button class="section__quantity-btn section__minus" onclick ="minusQuantity(${item.productId})">
                                                    <i class="bx bx-minus"></i>
                                                </button>
                                                <input type="number" class="section__input-text" step="1" min="1"
                                                       name="quantity" value="${(item.quantity)}" title="Qty" placeholder="">
                                                <button class="section__quantity-btn section__plus" onclick ="plusQuantity(${item.productId})">
                                                    <i class="bx bx-plus"></i>
                                                </button>
                                            </div>
                                        </div>
                                    </td>

                                    <td>
                                        <div class="table__content">
                                            <p class="table__content-total"> ${(amount)}$</p>
                                        </div>
                                    </td>
                                    <td>
                                        <div class="table__content">
                                            <i class='table__content-icon bx bxs-trash' onclick ="remove(${item.productId})"></i>
                                        </div>
                                    </td>
                                </tr>`
                document.querySelector('.table__body').innerHTML = html;
                total += amount
            }
            document.querySelector('.table__body').innerHTML = html;
            let html2 = `
                    <tr>
                        <th class="cart__title">Total</th>
                        <td class="cart__heading heading--primary">${total}$</td>
                    </tr>`
            document.querySelector('.cart__table').innerHTML = html2
        })
        .catch((error) => {
            console.error('Error:', error);
        });
}

minusQuantity = (id) => {
    let value = document.querySelector(`#item_${id} .section__input-text`);
    if (parseInt(value.value) > 1) {
        const quantity = parseInt(value.value) - 1;
        updateCart(id, quantity);
    }
};

plusQuantity = (id) => {
    let value = document.querySelector(`#item_${id} .section__input-text`);
    const quantity = parseInt(value.value) + 1;
    updateCart(id, quantity);
};
remove = (id) => {
    updateCart(id, 0);
};

function updateCart(id, quantity) {
    const data = { ProductId: id, Quantity: quantity };
    fetch(`/Cart/UpdateCart`, {
        method: 'POST', // or 'PUT'
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(data),
    })
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
            loadData()
        })
        .catch((error) => {
            console.error('Error:', error);
        });
}