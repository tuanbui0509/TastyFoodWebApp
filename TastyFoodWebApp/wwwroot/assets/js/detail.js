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
    let i, thumb,thumbs,image
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