/*==================== CHANGE TABS CATEGORY ====================*/
changeTab = (event, tab) => {
    let i, tabContent, tabLinks
    tabContent = document.getElementsByClassName('organically__pills')
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