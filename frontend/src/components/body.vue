<template>
  <div>
    <div class="page-wrapper" :class="layout.settings.sidebar.type == 'horizontal_sidebar' ? 'horizontal-wrapper' : 'compact-wrapper'">
      <div class="page-header shadow shadow-showcase" :class="{ close_icon:!togglesidebar }">
        <Header @clicked="sidebar_toggle" />
      </div>
      <div class="page-body-wrapper" :class="layout.settings.sidebar.type == 'horizontal_sidebar' ? 'horizontal-menu' : 'sidebar-icon'">
        <div class="sidebar-wrapper" :class="[{ close_icon : !togglesidebar }, layout.settings.sidebar_backround]" :sidebar-layout="layout.settings.sidebar_setting">
          <Sidebar @clicked="sidebar_toggle" />
        </div>
        <div class="page-body">
          <transition name="fadeIn" enter-active-class="animated fadeIn">
           <router-view class="view" style="max-width:1200px"></router-view>
          </transition>
        </div>
      </div>
      <Customizer/>
    </div>
    <Footer/>
  </div>
</template>

<script>
import { mapState } from "vuex";
import Header from './header'
import Sidebar from './sidebar'
import Footer from './footer'
import Customizer from './customizer'

export default {
  name: 'mainpage',
  data(){
    return{
      mobileheader_toggle_var: false,
      sidebar_toggle_var: false,
      horizontal_Sidebar: true,
      resized:false
    }
  },
  // props:['sidebar_toggle_var'],
  components:{
    Header,
    Sidebar,
    Footer,
    Customizer
  },
  computed: {
    ...mapState({
      menuItems: state => state.menu.data,
      layout: state => state.layout.layout,
      togglesidebar: (state) => state.menu.togglesidebar
    })
  },
  created(){
    window.addEventListener('resize', this.handleResize)
    this.handleResize();
    this.resized = this.sidebar_toggle_var;
    this.$store.dispatch('layout/set')
  },
  watch:{
    '$route' (){
      this.menuItems.filter(items => {
        if (items.path === this.$route.path)
          this.$store.dispatch('menu/setActiveRoute', items)
        if (!items.children) return false
        items.children.filter(subItems => {
          if (subItems.path === this.$route.path)
            this.$store.dispatch('menu/setActiveRoute', subItems)
          if (!subItems.children) return false
          subItems.children.filter(subSubItems => {
            if (subSubItems.path === this.$route.path)
              this.$store.dispatch('menu/setActiveRoute', subSubItems)
          })
        })
      })
    },
    sidebar_toggle_var: function (){
      this.resized = (this.width <= 991) ? !this.sidebar_toggle_var : this.sidebar_toggle_var      
    }
  },
  methods:{
    sidebar_toggle(value) {
      this.sidebar_toggle_var = !value
    },
    mobiletoggle_toggle(value) {
      this.mobileheader_toggle_var = value
    },
    handleResize() {
      this.$store.dispatch("menu/resizetoggle");
    }
  }
}
</script>

<style lang="scss" scoped>


</style>
