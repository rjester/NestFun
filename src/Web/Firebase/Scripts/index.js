var s,
    client_id,
    index = {
        settings: {
            state: 'proto',
            authUrl: 'https://home.nest.com/login/oauth2'
        },
        loginButton: $('#LoginButton'),
        init: function () {
            s = this.settings;
            var obj = {};
            var jqxhr = $.getJSON("/Scripts/keys.json", function(data) {
                    $.each(data, function(key, val) {
                        obj[key] = val;
                    });
                })
                .done(function() {
                    //$.each(obj, function (idx, val) {
                    //    keys[key] = val;
                    //});
                    client_id = obj.client_id;
                })
                .fail(function(jqxhr, textStatus, error) {
                    var err = textStatus + ", " + error;
                    console.log("Request Failed: " + err);
                });

            
        },

        buildAuthUrl: function () {
            return s.authUrl.concat("?client_id=", client_id, "&state=", s.state);
        }

    };
index.init();
index.loginButton.click(function () {
    alert(index.buildAuthUrl());
    window.location.href = index.buildAuthUrl();
});

