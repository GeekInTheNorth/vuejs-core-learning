var app = new Vue({
    el: '#app',
    data: {
        Collection: null
    },
    mounted() {
        this.getData();
    },
    methods: {
        getData: function () {
            var url = window.location.origin + "/api/Data/Collection";
            $.get(url).done(data => {
                this.Collection = data;
            });
        },
        save: function () {
            var url = window.location.origin + "/api/Data/Collection";
            post(url, this.Collection);
        }
    }
});