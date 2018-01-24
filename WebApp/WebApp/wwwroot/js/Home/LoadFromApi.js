var app = new Vue({
    el: '#app',
    data: {
        results: []
    },
    mounted() {
        var url = window.location.origin + "/api/Data";
        $.get(url).done(data => {
            this.results = data;
        });
    }
});