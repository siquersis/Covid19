import Vue from "../vue/vue.js";

var paises = Vue.component({
    name: "paises",
    template: `<p>{{mensagem}}</p>`
});

const vm = new Vue({
    el: "#app",
    data: {
        mensagem: 'Testando VueJs'
    },
    components: {
        paises
    }
});

export default {
    paises;
};

