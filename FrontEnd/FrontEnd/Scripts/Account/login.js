

function onSignIn(googleUser) {
    //var profile = googleUser.getBasicProfile();
    var id_token = googleUser.getAuthResponse().id_token;
    //console.log('Name: ' + profile.getName());
    //console.log('Image URL: ' + profile.getImageUrl());
    //console.log('Email: ' + profile.getEmail()); // This is null if the 'email' scope is not present.

    if (typeof (Storage) !== "undefined") {
        sessionStorage.authToken = id_token;
        console.log('Token: ' + sessionStorage.authToken);
    }
}

function onError(googleUser) {
    console.log("Error");
}