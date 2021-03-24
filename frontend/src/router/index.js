import Vue from 'vue'
import Router from "vue-router";

import Body from '../components/body'

import SamplePage from '../pages/sample_page'

//Authentication
import Login from '../pages/authentication/login'
import Register from '../pages/authentication/register'

//Dashboard
import Purple from '../pages/dashboard/purple'
import Profile from '../pages/dashboard/profile'

//Other
import Faq from '../pages/other/faq'
import Pricing from '../pages/other/pricing'

//Advertisement
import Ad from '../pages/ad/joblist'
import Detail from '../pages/ad/detail'
import NewJob from '../pages/ad/newjob'

//Chat
import Chat from '../pages/chat/chat'

// component

Vue.use(Router)

const routes = [
  { path: '', redirect: { name: 'Login' }},
  {
    path: '/dashboard',
    component: Body,
    children: [
    {
      path: 'default',
      name: 'default',
      component: SamplePage,
      meta: {
        title: 'Default Dashboard | Endless - Premium Admin Template',
      }
    },
    {
      path: 'purple',
      name: 'purple',
      component: Purple,
      meta: {
        title: 'Purple Dashboard | Endless - Premium Admin Template',
      }
    },
    {
      path: 'profile',
      name: 'profile',
      component: Profile,
      meta: {
        title: 'Profile | Endless - Premium Admin Template',
      }
    }
    ]},
    {
      path:'/authentication/login',
      name:'Login',
      component:Login,
      meta: {
          title: 'Login | Purple Admin Template',
        }
    },
    {
      path:'/authentication/register',
      name:'Register',
      component:Register,
      meta: {
          title: 'Register | Purple Admin Template',
        }
    },
    {
      path: '/other',
      component: Body,
      children: [
      {
        path: 'Faq',
        name: 'Faq',
        component: Faq,
        meta: {
          title: 'FAQ | Purple Admin Template',
        }
      },
      {
        path: 'Pricing',
        name: 'Pricing',
        component: Pricing,
        meta: {
          title: 'Pricing | Purple Admin Template',
        }
      }
      ]},
      {
        path: '/ad',
        component: Body,
        children: [
        {
          path: 'JobList',
          name: 'JobList',
          component: Ad,
          meta: {
            title: 'Advertisements | Purple Admin Template',
          }
        },
        {
          path: 'NewJob',
          name: 'NewJob',
          component: NewJob,
          meta: {
            title: 'New Advertisement | Purple Admin Template',
          }
        },
        {
          path: 'Detail',
          name: 'Detail',
          component: Detail,
          meta: {
            title: 'Advertisement Detail | Purple Admin Template',
          }
        }
      ]},
      {
        path: '/chat',
        component: Body,
        children: [
        {
          path: 'list',
          name: 'list',
          component: Chat,
          meta: {
            title: 'Chat | Purple Admin Template',
          }
        },
      ]},
  ];

const router = new Router({
  routes,
  base: '/',
  mode: 'history',
  linkActiveClass: "active",
  scrollBehavior () {
    return { x: 0, y: 0 }
  }
});

export default router
