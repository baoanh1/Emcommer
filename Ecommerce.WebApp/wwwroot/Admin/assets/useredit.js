/*global
    piranha userlist
*/

useredit = new Vue({
    el: "#useredit",
    data: {
        loading: true,
        isNew: false,
        userModel: null,
        currentUserName: null
    },
    methods: {
        bind: function (result) {
            this.userModel = result;
            this.isNew = result.user.id === "00000000-0000-0000-0000-000000000000";
        },
        load: function (id, isNew) {
            var self = this;

            var url = isNew ? baseUrl + "manager/user/add" : baseUrl + "manager/user/edit/" + id;

            fetch(url)
                .then(function (response)
                {
                    return response.json();
                })
                .then(function (result) {
                    self.bind(result);
                    self.loading = false;
                })
                .catch(function (error) { console.log("error:", error); });
        },
        getRoleRows: function () {
            var roleRows = Array();
            for (var i = 0, j = this.userModel.roles.length; i < j; i += 3) {
                roleRows.push(this.userModel.roles.slice(i, i + 3));
            }
            return roleRows;
        },
       
        save: function () {
            // Validate form
            var form = document.getElementById("usereditForm");
            if (form.checkValidity() === false) {
                form.classList.add("was-validated");
                return;
            }

            var ok = false;
            var self = this;
            console.log(JSON.stringify(self.userModel));
            fetch(baseUrl + "manager/user/save", {
                method: "post",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify(self.userModel)
            })
                .then(function (response) {
                    ok = response.ok;
                    return response.json();
                })
                .then(function (result) {
                    if (ok) {
                        self.bind(result);

                        notifications.push({
                            body: "luu thanh cong",
                            type: "success",
                            hide: true
                        });
                    }
                    else if (result.status) {
                        notifications.push(result.status);
                    }
                    else {
                        notifications.push({
                            body: "<strong>" + "co loi xay ra" + "</strong>",
                            type: "danger",
                            hide: true
                        });
                    }

                })
                .catch(function (error) {
                    notifications.push({
                        body: error,
                        type: "danger",
                        hide: true
                    });

                    console.log("error:", error);
                });
        },
    }
});
