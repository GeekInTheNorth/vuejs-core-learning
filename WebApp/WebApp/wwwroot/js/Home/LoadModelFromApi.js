var app = new Vue({
    el: '#app',
    data: {
        selected: 1,
        employee: {
            forename: "",
            surname: ""
        }
    },
    mounted() {
        this.getData();
    },
    methods: {
        getData: function () {
            var id = this.selected;
            var url = window.location.origin + "/api/Data/view/" + id;
            $.get(url).done(data => {
                this.employee = data;
            });
        }
    }
});