<template>
  <div>
      <nav class="sidebar-main">
        <div id="sidebar-menu" style="margin-top:50px">
          <ul class="sidebar-links custom-scrollbar" id="myDIV" style="width:50%;float:right;"
          :style="[layout.settings.sidebar.type == 'horizontal_sidebar' ? layout.settings.layout_type=='rtl'? {'margin-right': margin+'px'} : {'margin-left': margin+'px'} :  { margin : '0px'}]"
          >
           <li
                v-for="(menuItem, index) in menuItems"
                :key="index"
                :class="{'active': menuItem.active, 'sidebar-main-title' : menuItem.type == 'headtitle'}"
                class="sidebar-list"
              >
                <div v-if="menuItem.type == 'headtitle'">
                  <h6 class="lan-1">{{ menuItem.headTitle1 }}</h6>
                  <p class="lan-2">{{ menuItem.headTitle2 }}</p>
                </div>
                <label
                      :class="'badge badge-'+menuItem.badgeType"
                      v-if="menuItem.badgeType"
                    >{{ menuItem.badgeValue }}</label>
                    <a
                  href="javascript:void(0)"
                  class="sidebar-link sidebar-title"
                  v-if="menuItem.type == 'sub'"
                  @click="setNavActive(menuItem, index)"
                >
                  <feather :type="menuItem.icon" class="top"></feather>
                  <span class="f-w-600">
                    {{ menuItem.title }}
                  </span>
                  <div class="according-menu" v-if="menuItem.children">
                    <i class="fa fa-angle-right pull-right" ></i>
                  </div>
                </a>
                <router-link
                  :to="menuItem.path"
                  class="sidebar-link sidebar-title"
                  v-if="menuItem.type == 'link'"
                  router-link-exact-active
                >
                  <feather :type="menuItem.icon" class="top"></feather>
                  <span>
                    {{ menuItem.title }}
                  </span>
                  <i class="fa fa-angle-right pull-right" v-if="menuItem.children"></i>
                </router-link>
                <a
                  :href="menuItem.path"
                  class="sidebar-link sidebar-title"
                  v-if="menuItem.type == 'extLink'"
                  @click="setNavActive(menuItem, index)"
                >
                  <feather :type="menuItem.icon" class="top"></feather>
                  <span>
                    {{ menuItem.title }}
                  </span>
                  <i class="fa fa-angle-right pull-right" v-if="menuItem.children"></i>
                </a>
                <a
                  :href="menuItem.path"
                  target="_blank"
                  class="sidebar-link sidebar-title"
                  v-if="menuItem.type == 'extTabLink'"
                  @click="setNavActive(menuItem, index)"
                >
                  <feather :type="menuItem.icon" class="top"></feather>
                  <span>
                    {{ menuItem.title }}
                  </span>
                  <i class="fa fa-angle-right pull-right" v-if="menuItem.children"></i>
                </a>
                <ul class="sidebar-submenu" v-if="menuItem.children" :class="{ 'menu-open': menuItem.active }">
                  <li
                    v-for="(childrenItem, index) in menuItem.children"
                    :key="index"
                    :class="{'active': childrenItem.active}"
                  >
                    <a
                      class="submenu-title"
                      href="javascript:void(0)"
                      v-if="childrenItem.type == 'sub'"
                      @click="setNavActive(childrenItem, index)"
                    >
                      {{ childrenItem.title }}
                      <label
                        :class="'badge badge-'+childrenItem.badgeType+' pull-right'"
                        v-if="childrenItem.badgeType"
                      >{{childrenItem.badgeValue}}</label>
                      <i class="fa fa-angle-right pull-right mt-1" v-if="childrenItem.children"></i>
                    </a>
                    <router-link
                      class="submenu-title"
                      :to="childrenItem.path"
                      v-if="childrenItem.type == 'link'"
                      router-link-exact-active
                    >
                      {{ childrenItem.title }}
                      <label
                        :class="'badge badge-'+childrenItem.badgeType+' pull-right'"
                        v-if="childrenItem.badgeType"
                      >{{ childrenItem.badgeValue }}</label>
                      <i class="fa fa-angle-right pull-right mt-1" v-if="childrenItem.children"></i>
                    </router-link>
                    <a :href="childrenItem.path" v-if="childrenItem.type == 'extLink'" class="submenu-title">
                      {{ childrenItem.title }}
                      <label
                        :class="'badge badge-'+childrenItem.badgeType+' pull-right'"
                        v-if="childrenItem.badgeType"
                      >{{ childrenItem.badgeValue }}</label>
                      <i class="fa fa-angle-right pull-right mt-1" v-if="childrenItem.children"></i>
                    </a>
                    <a
                    class="submenu-title"
                      :href="childrenItem.path"
                      target="_blank"
                      v-if="childrenItem.type == 'extTabLink'"
                    >
                      {{ childrenItem.title }}
                      <label
                        :class="'badge badge-'+childrenItem.badgeType+' pull-right'"
                        v-if="childrenItem.badgeType"
                      >{{ childrenItem.badgeValue }}</label>
                      <i class="fa fa-angle-right pull-right mt-1" v-if="childrenItem.children"></i>
                    </a>
                    <ul class="nav-sub-childmenu submenu-content" v-if="childrenItem.children" :class="{ 'opensubchild': childrenItem.active }">
                      <li v-for="(childrenSubItem, index) in childrenItem.children" :key="index">
                        <router-link
                          :to="childrenSubItem.path"
                          v-if="childrenSubItem.type == 'link'"
                          router-link-exact-active
                        >
                          {{ childrenSubItem.title }}
                          <label
                            :class="'badge badge-'+childrenSubItem.badgeType+' pull-right'"
                            v-if="childrenSubItem.badgeType"
                          >{{ childrenSubItem.badgeValue }}</label>
                          <i class="fa fa-angle-right pull-right" v-if="childrenSubItem.children"></i>
                        </router-link>
                        <router-link
                          :to="childrenSubItem.path"
                          v-if="childrenSubItem.type == 'extLink'"
                          router-link-exact-active
                        >
                          {{ childrenSubItem.title }}
                          <label
                            :class="'badge badge-'+childrenSubItem.badgeType+' pull-right'"
                            v-if="childrenSubItem.badgeType"
                          >{{ childrenSubItem.badgeValue }}</label>
                          <i class="fa fa-angle-right pull-right" v-if="childrenSubItem.children"></i>
                        </router-link>
                        <router-link
                          :to="childrenSubItem.path"
                          v-if="childrenSubItem.type == 'extLink'"
                          router-link-exact-active
                        >
                          {{ childrenSubItem.title }}
                          <label
                            :class="'badge badge-'+childrenSubItem.badgeType+' pull-right'"
                            v-if="childrenSubItem.badgeType"
                          >{{ childrenSubItem.badgeValue }}</label>
                          <i class="fa fa-angle-right pull-right" v-if="childrenSubItem.children"></i>
                        </router-link>
                      </li>
                    </ul>
                  </li>
                </ul>
              </li>
              <div class="mt-4 m-r-10 m-l-40" style="border-top:1px solid #dce1e1">
                <p class="txt-dark mt-3">Purple © 2021</p>
              </div>
          </ul>
        </div>
        <li
          class="right-arrow"
          :class="{'d-none': layout.settings.layout_type=='rtl'? hideRightArrowRTL : hideRightArrow }"
          @click="(layout.settings.sidebar.type == 'horizontal_sidebar' && layout.settings.layout_type=='rtl') ? scrollToRightRTL() : scrollToRight()"
        >
          <feather type="arrow-right"></feather>
        </li>
      </nav>
  </div>
</template>
<script>
import { mapState } from "vuex";
export default {
  name: "Sidebar",
  data() {
    return {
      width: 0,
      height: 0,
      margin: 0,
      hideRightArrowRTL: true,
      hideLeftArrowRTL: true,
      hideRightArrow: true,
      hideLeftArrow: true,
      menuWidth: 0,
      toggle_sidebar_var: false,
      clicked: false
    };
  },
  computed: {
    ...mapState({
      menuItems: state => state.menu.data,
      layout: state => state.layout.layout,
      sidebar: state => state.layout.sidebarType
    })
  },
  created() {
    window.addEventListener("resize", this.handleResize);
    this.handleResize();
    if (this.width < 991) {
      this.layout.settings.sidebar.type = "default";
    }
    const val  = this.sidebar
      if (val == 'default') {			
				this.layout.settings.sidebar.type = 'default';
				this.layout.settings.sidebar.body_type = 'default';
			} else if (val == 'compact') {
				this.layout.settings.sidebar.type = 'compact-wrapper';
				this.layout.settings.sidebar.body_type = 'sidebar-icon';
			} else if (val == 'compact-icon') {
				this.layout.settings.sidebar.type = 'compact-page';
				this.layout.settings.sidebar.body_type = 'sidebar-hover';
			} else if (val == 'horizontal')  {
				this.layout.settings.sidebar.type = 'horizontal_sidebar';
        this.layout.settings.sidebar.body_type = '';
      }
      setTimeout(()=> {
        const elmnt = document.getElementById("myDIV");
        this.menuWidth = elmnt.offsetWidth;   
        this.menuWidth > window.innerWidth  ? (this.hideRightArrow = false,this.hideLeftArrowRTL = false) : (this.hideRightArrow = true,this.hideLeftArrowRTL = true)
      }, 500)
  },
  destroyed() {
    window.removeEventListener("resize", this.handleResize);
  },
  mounted() {   
    this.menuItems.filter(items => {
      if (items.path === this.$route.path)
        this.$store.dispatch("menu/setActiveRoute", items);
      if (!items.children) return false;
      items.children.filter(subItems => {
        if (subItems.path === this.$route.path)
          this.$store.dispatch("menu/setActiveRoute", subItems);
        if (!subItems.children) return false;
        subItems.children.filter(subSubItems => {
          if (subSubItems.path === this.$route.path)
            this.$store.dispatch("menu/setActiveRoute", subSubItems);
        });
      });
    });
  },
  methods: {
    toggle_sidebar() {
      this.$store.dispatch("menu/opensidebar");
    },
    setNavActive(item) {
      this.$store.dispatch("menu/setNavActive", item);
    },
    handleResize() {
      this.width = window.innerWidth - 310;
    },
    scrollToRightRTL() {
      this.temp = this.width + this.margin;
      // Checking condition for remaing margin
      if (this.temp === 0) {
        this.margin = this.temp;
        this.hideRightArrowRTL = true;
      }
      // else
      else {
        this.margin += this.width;
        this.hideRightArrowRTL = false;
        this.hideLeftArrowRTL = false;
      }
    },
    scrollToLeftRTL() {
      // If Margin is reach between screen resolution
      console.log("this.margin", this.margin);
      if (this.margin <= -this.width) {
        this.margin += -this.width;
        this.hideLeftArrowRTL = true;
      }
      //Else
      else {
        this.margin += -this.width;
        this.hideRightArrowRTL = false;
      }
    },
    scrollToLeft() {
      console.log('left');
      
      // If Margin is reach between screen resolution
      if (this.margin >= -this.width) {
        this.margin = 0;
        this.hideLeftArrow = true;
      }
      //Else
      else {
        this.margin += this.width;
        this.hideRightArrow = false;
      }
    },
    scrollToRight() {
      this.temp = this.menuWidth + this.margin;
      // Checking condition for remaing margin
      if (this.temp < this.menuWidth) {
        this.margin = -this.temp;
        this.hideRightArrow = true;
      }
      // else
      else {
        this.margin += -this.width;
        this.hideLeftArrow = false;
      }
    }
  }
};
</script>
