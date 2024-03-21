function saveAsFile(filename, bytesBase64) {
    var link = document.createElement('a');
    link.href = "data:application/octet-stream;base64," + bytesBase64;
    link.download = filename;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}
