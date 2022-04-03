function Yuklendi() {
    //masterdan miras alınan content-275 ve content-300 classlarını burda gizlemek amac bu sayfada onlar gorunmesin
    var Content275 = document.getElementById("c275").style.display = 'none';// divin id'sini al ve gizle
    var Content300 = document.getElementById("c300").style.display = 'none';
    //
    var rol = document.getElementById("lblaltUst").innerHTML;
}
window.onload = Yuklendi;