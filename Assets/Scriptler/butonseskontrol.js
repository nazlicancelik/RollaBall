#pragma strict

var ses1:AudioClip;  // Ses klibi tanımladık. İnspector panelinde sürükle bırak yöntemi ile sesi tanımlayacağız.
var ses2:AudioClip;  // Ses klibi tanımladık. İnspector panelinde sürükle bırak yöntemi ile sesi tanımlayacağız.

function OnMouseEnter(){  // OnMouseEnter anlaşıldığı üzere mouse objenin üzerine gelince yapılacak işler.
    GetComponent.<AudioSource>().PlayOneShot(ses1);  // Ses1 adlı ses dosyası bir kere oynatılıyor.
} 
function OnMouseExit(){  // OnMouseExit mouse objenin üzerinden çıkınca yapılacak işler.
    GetComponent.<AudioSource>().PlayOneShot(ses2); // Ses2 adlı ses dosyası bir kere oynatılıyor.
}
