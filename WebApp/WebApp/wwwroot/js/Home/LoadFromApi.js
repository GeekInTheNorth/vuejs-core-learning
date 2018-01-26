var app = new Vue({
    el: '#app',
    data: {
        results: []
    },
    mounted() {
        var url = window.location.origin + "/api/Data/list";
        $.get(url).done(data => {
            this.results = data;
        });
    }
});