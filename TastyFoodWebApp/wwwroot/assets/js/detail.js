openTab = (event, tab) => {
    let i, tabContent, tabLinks
    tabContent = document.getElementsByClassName('tabs-pill')
    for (i = 0; i < tabContent.length; i++) {
        tabContent[i].style.display = "none";
    }
    tabLinks = document.getElementsByClassName("tabs-item")
    for (i = 0; i < tabLinks.length; i++) {
        tabLinks[i].className = tabLinks[i].className.replace("tabs-item--active", "")
    }
    document.getElementById(tab).style.display = 'block'
    event.currentTarget.className += ' tabs-item--active'
}

changePicture = (event) => {
    let i, thumb, thumbs, image
    thumbs = document.getElementsByClassName('detail__other-thumb-item')
    for (i = 0; i < thumbs.length; i++) {
        if (thumbs[i].className.includes('detail__other-thumb-item--overlay')) { }
        else
            thumbs[i].className += ' detail__other-thumb-item--overlay'
    }
    event.currentTarget.className = event.currentTarget.className.replace("detail__other-thumb-item--overlay", "")
    image = event.currentTarget.querySelector('.detail__other-thumb-img').src
    thumb = document.getElementsByClassName('detail__image-main')
    thumb[0].src = image;
}

minusQuantity = (id) => {
    let value = document.querySelector(`.section__input-text`).value;
    if (parseInt(value) > 1) {
        const quantity = parseInt(value) - 1;
        updateCart(id, quantity);
        document.querySelector(`.section__input-text`).value = quantity;
    }
};

plusQuantity = (id) => {
    let value = document.querySelector(`.section__input-text`).value;
    const quantity = parseInt(value) + 1;
    updateCart(id, quantity);
    document.querySelector(`.section__input-text`).value = quantity;
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
        })
        .catch((error) => {
            console.error('Error:', error);
        });
}

// ================= ADD REVIEW ==================

addReview = (e, id) => {
    e.preventDefault()
    let comment = document.getElementById('content-review')
    let rate = document.querySelector('input[name="rate"]:checked').value
    let data = {
        UserId: '00000000-0000-0000-0000-000000000000',
        Comment: comment.value,
        Rate: rate,
        ProductId: id
    };
    fetch(`/Product/CreateReview`, {
        method: 'POST', // or 'PUT'
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(data),
    })
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
            window.onload
        })
        .catch((error) => {
            console.error('Error:', error);
        });
}