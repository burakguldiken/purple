import Vue from "vue";
import Vuex from "vuex";
// import 'es6-promise/auto';
import layout from './modules/layout'
import menu from './modules/menu'
import email from './modules/email'
import jobs from './modules/jobs'
import chat from './modules/chat'
import todo from './modules/todo'
Vue.use(Vuex);

export const store = new Vuex.Store({
    modules: {
      layout,
      menu,
      email,
      jobs,
      chat,
      todo
    }
});

