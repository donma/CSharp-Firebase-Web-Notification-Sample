importScripts('https://www.gstatic.com/firebasejs/4.8.1/firebase-app.js');
importScripts('https://www.gstatic.com/firebasejs/4.8.1/firebase-messaging.js');

var config = {
    messagingSenderId: "548756765078"
};

firebase.initializeApp(config);
messaging = firebase.messaging();
messaging.setBackgroundMessageHandler(function (payload) {
    console.log('Received background message ', payload);

});

console.log("Loaded SW..");