import Vue from 'vue'
import App from './App.vue'
import BootstrapVue from 'bootstrap-vue'
import router from './router'
import Breadcrumbs from './components/bread_crumbs'
import { store } from './store';
import VueFeather from 'vue-feather';
import { Vue2Dragula } from 'vue2-dragula'
import Toasted from 'vue-toasted';
import Vue2Filters from 'vue2-filters'
import VueSweetalert2 from 'vue-sweetalert2';
import Notifications from 'vue-notification'
import FunctionalCalendar from 'vue-functional-calendar';
import SmartTable from 'vuejs-smart-table'
import VueFormWizard from 'vue-form-wizard';
import VueTour from 'vue-tour'
import VueApexCharts from 'vue-apexcharts';

import { Icon } from "leaflet";
delete Icon.Default.prototype._getIconUrl;

import PxCard  from './components/Pxcard.vue'
Vue.component(PxCard.name, PxCard)

// Import Theme scss
import './assets/scss/app.scss'

Vue.use(Toasted,{
  iconPack: 'fontawesome'
});
Vue.use(Vue2Dragula);

Vue.use(VueFormWizard)
Vue.use(VueTour)
Vue.use(require('vue-chartist'))
Vue.use(SmartTable)
Vue.use(require('vue-moment'));
Vue.use(Notifications)
Vue.use(Vue2Filters)
Vue.use(VueSweetalert2);
Vue.use(VueFeather);
Vue.use(BootstrapVue)
Vue.component('apexchart', VueApexCharts)
Vue.use(FunctionalCalendar, {
  dayNames: ['M', 'T', 'W', 'T', 'F', 'S', 'S']
});
Vue.component('Breadcrumbs', Breadcrumbs)

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')