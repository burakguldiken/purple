<template>
  <div>
    <div class="customizer-links" :class="{ open: customizer }">
      <div class="nav flex-column nac-pills" id="c-pills-tab">
        <a
          class="nav-link"
          :class="{ 'active show': customizer == 'settings' }"
          id="c-pills-home-tab"
          @click="openCustomizerSetting('settings')"
          href="javascript:void(0)"
        >
          <div class="settings">
            <i class="icon-settings"></i>
          </div>
          <span>Quick option</span>
        </a>
        <a
          class="nav-link"
          target="_blank"
          href="https://pixelstrap.freshdesk.com/"
        >
          <div>
            <i class="icon-support"></i>
          </div>
          <span>Support</span>
        </a>
        <a
          class="nav-link"
          target="_blank"
          href="http://admin.pixelstrap.com/cuba/document/index.html"
        >
          <div>
            <i class="icon-settings"></i>
          </div>
          <span>Document</span>
        </a>
        <a
          class="nav-link"
          target="_blank"
          href="http://admin.pixelstrap.com/cuba/theme/landing-page.html#frameworks"
        >
          <div>
            <i class="icon-panel"></i>
          </div>
          <span>Check features</span>
        </a>
        <a
          class="nav-link"
          target="_blank"
          href="https://1.envato.market/3GVzd"
        >
          <div>
            <i class="icon-shopping-cart-full"></i>
          </div>
          <span>Buy now</span>
        </a>
      </div>
    </div>
    <div class="customizer-contain" :class="{ open: customizer }">
      <div class="tab-content">
        <div class="customizer-header">
          <i class="icofont-close icon-close" @click="customizer = ''"></i>
          <h5>Customizer</h5>
          <p class="mb-0">Try It Real Time <i class="fa fa-thumbs-o-up txt-primary"></i></p>
          <button
            v-b-modal.modal-customizer
            class="btn btn-primary plus-popup mt-2"
          >
            Configuration
          </button>
          <b-modal
            id="modal-customizer"
            title="Modal Title"
            class="theme-modal"
          >
            <div class="modal-header modal-copy-header">
              <h5 class="headerTitle mb-0">Customizer configuration</h5>
            </div>
            <div class="modal-body">
              <div class="config-popup">
                <p>
                  To replace our design with your desired theme. Please do
                  configuration as mention
                </p>
                <p>
                  <b>Path : src > data > layout.json</b>
                </p>
                <div>
                  <pre>
										<code>
											<b-form-textarea :value="data" ref="layout" rows="1" v-bind:style="styleObject"></b-form-textarea>
											{{layout}}
										</code>
									</pre>
                </div>
                <button class="btn btn-primary mt-2" @click="copyText()">
                  Copy Json
                </button>
              </div>
            </div>
          </b-modal>
        </div>
        <div class="customizer-body custom-scrollbar">
          <div class="tab-pane fade active show" id="c-pills-home">
            <h6>Layout Type</h6>
            <ul class="main-layout layout-grid">
              <li data-attr="ltr"
                :class="{ active: layoutType == 'ltr' }"
                @click="customizeLayoutType('ltr')">
                <div class="header bg-light">
                  <ul>
                    <li></li>
                    <li></li>
                    <li></li>
                  </ul>
                </div>
                <div class="body">
                  <ul>
                    <li class="bg-light sidebar"></li>
                    <li class="bg-light body">
                      <span class="badge badge-primary">LTR</span>
                    </li>
                  </ul>
                </div>
              </li>
              <li data-attr="rtl"
                :class="{ active: layoutType == 'rtl' }"
                @click="customizeLayoutType('rtl')">
                <div class="header bg-light">
                  <ul>
                    <li></li>
                    <li></li>
                    <li></li>
                  </ul>
                </div>
                <div class="body">
                  <ul>
                    <li class="bg-light body">
                      <span class="badge badge-primary">RTL</span>
                    </li>
                    <li class="bg-light sidebar"></li>
                  </ul>
                </div>
              </li>
              <li data-attr="box"
                :class="{ active: layoutType == 'box-layout' }"
                @click="customizeLayoutType('box-layout')" class="box-layout px-3">
                <div class="header bg-light">
                  <ul>
                    <li></li>
                    <li></li>
                    <li></li>
                  </ul>
                </div>
                <div class="body">
                  <ul>
                    <li class="bg-light sidebar"></li>
                    <li class="bg-light body">
                      <span class="badge badge-primary">Box</span>
                    </li>
                  </ul>
                </div>
              </li>
            </ul>
            <h6 class="">Sidebar Type</h6>
            <ul class="sidebar-type layout-grid">
              <li 
                data-attr="horizontal-sidebar"
                class="horizontal-sidebar"
                :class="{
                  active: layout.settings.sidebar.type == 'horizontal_sidebar',
                }"
                @click="customizeSidebarType('horizontal')">
                <div class="header bg-light">
                  <ul>
                    <li></li>
                    <li></li>
                    <li></li>
                  </ul>
                </div>
                <div class="body">
                  <ul>
                    <li class="bg-dark sidebar"></li>
                    <li class="bg-light body"></li>
                  </ul>
                </div>
              </li>
              <li
                data-attr="default-sidebar"
                :class="{ active: layout.settings.sidebar.type == 'default' }"
                @click="customizeSidebarType('default')">
                <div class="header bg-light">
                  <ul>
                    <li></li>
                    <li></li>
                    <li></li>
                  </ul>
                </div>
                <div class="body">
                  <ul>
                    <li class="bg-dark sidebar compact"></li>
                    <li class="bg-light body"></li>
                  </ul>
                </div>
              </li>
            </ul>
            <h6 class="">Sidebar settings</h6>
            <ul class="sidebar-setting layout-grid">
              <li
              data-attr="default-sidebar"
                :class="{
                  active: layout.settings.sidebar_setting == 'default-sidebar',
                }"
                @click="customizeSidebarSetting('default-sidebar')">
                <div class="header bg-light">
                  <ul>
                    <li></li>
                    <li></li>
                    <li></li>
                  </ul>
                </div>
                <div class="body bg-light">
                  <span class="badge badge-primary">Default</span>
                </div>
              </li>
              <li
              data-attr="border-sidebar"
                :class="{
                  active: layout.settings.sidebar_setting == 'border-sidebar',
                }"
                @click="customizeSidebarSetting('border-sidebar')">
                <div class="header bg-light">
                  <ul>
                    <li></li>
                    <li></li>
                    <li></li>
                  </ul>
                </div>
                <div class="body bg-light">
                  <span class="badge badge-primary">Border</span>
                </div>
              </li>
              <li
              data-attr="iconcolor-sidebar"
                :class="{
                  active:
                    layout.settings.sidebar_setting == 'iconcolor-sidebar',
                }"
                @click="customizeSidebarSetting('iconcolor-sidebar')">
                <div class="header bg-light">
                  <ul>
                    <li></li>
                    <li></li>
                    <li></li>
                  </ul>
                </div>
                <div class="body bg-light">
                  <span class="badge badge-primary">icon Color</span>
                </div>
              </li>
            </ul>
            <h6 class="">Unlimited Color</h6>
            <ul class="layout-grid unlimited-color-layout">
              <input
                id="ColorPicker1"
                type="color"
                value="#7366ff"
                name="Background"
              />
              <input
                id="ColorPicker2"
                type="color"
                value="#f73164"
                name="Background"
              />
              <button
                type="button"
                class="color-apply-btn btn btn-primary color-apply-btn"
                @click="customizeColor"
              >
                Apply
              </button>
              <button
                type="button"
                class="color-apply-btn btn btn-primary color-reset-btn ml-2"
                @click="resetColor"
              >
                Reset
              </button>
            </ul>
            <h6 class="">Mix Layout</h6>
            <ul class="layout-grid customizer-mix">
              <li class="color-layout" 
                data-attr="light-only"
                :class="{ active: mixLayout == 'light-only' }"
                @click="customizeMixLayout('light-only')">
                <div class="header bg-light">
                  <ul>
                    <li></li>
                    <li></li>
                    <li></li>
                  </ul>
                </div>
                <div class="body">
                  <ul>
                    <li class="bg-light sidebar"></li>
                    <li class="bg-light body"></li>
                  </ul>
                </div>
              </li>
              <li class="color-layout" data-attr="dark-sidebar"
                :class="{ active: mixLayout == 'dark-sidebar' }"
                @click="customizeMixLayout('dark-sidebar')">
                <div class="header bg-light">
                  <ul>
                    <li></li>
                    <li></li>
                    <li></li>
                  </ul>
                </div>
                <div class="body">
                  <ul>
                    <li class="bg-dark sidebar"></li>
                    <li class="bg-light body"></li>
                  </ul>
                </div>
              </li>
              <li class="color-layout" data-attr="dark-only"
                :class="{ active: mixLayout == 'dark-only' }"
                @click="customizeMixLayout('dark-only')">
                <div class="header bg-dark">
                  <ul>
                    <li></li>
                    <li></li>
                    <li></li>
                  </ul>
                </div>
                <div class="body">
                  <ul>
                    <li class="bg-dark sidebar"></li>
                    <li class="bg-dark body"></li>
                  </ul>
                </div>
              </li>
            </ul>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
import { mapState } from "vuex";
export default {
  name: "customizer",
  data() {
    return {
      customizer: "",
      sidebarSetting: "color",
      layoutType: "ltr",
      sidebarType: "default",
      mixLayout: "default",
      styleObject: {
        position: "fixed",
        left: "0",
        top: "0",
        opacity: "0",
      },
    };
  },
  mounted() {
    this.layout.color.color = localStorage.getItem("color");
    this.layout.color.primary_color = localStorage.getItem("primary_color");
    this.layout.color.secondary_color = localStorage.getItem("secondary_color");
  },
  computed: {
    ...mapState({
      layout: (state) => state.layout.layout,
      data: (state) => JSON.stringify(state.layout.layout),
    }),
  },
  methods: {
    openCustomizerSetting(val) {
      this.customizer = val;
    },
    customizerSetting(val) {
      this.sidebarSetting = val;
    },
    customizeLayoutType(val) {
      this.$store.dispatch("layout/setLayoutType", val);
      this.layoutType = val;
    },
    customizeSidebarType(val) {
      console.log(val);
      this.$store.dispatch("layout/setCustomizeSidebarType", val);
    },
    customizeSidebarSetting(val) {
      console.log(val);
      this.layout.settings.sidebar_setting = val;
    },
    customizeSidebarBackround(val) {
      console.log(val);
      this.layout.settings.sidebar_backround = val;
    },
    customizeMixLayout(val) {
      console.log(val);
      this.mixLayout = val;
      this.$store.dispatch("layout/setLayout", val);
    },
    customizeColor() {
      const primary = document.getElementById("ColorPicker1").value;
      const secondary = document.getElementById("ColorPicker2").value;
      this.$store.dispatch("layout/setColorScheme", {primary, secondary});
    },
    resetColor() {
      localStorage.setItem("primary_color", "#7366ff");
      localStorage.setItem("secondary_color", "#f73164");
      window.location.reload();
    },
    customizeDarkColorScheme(val) {
      this.$store.dispatch("layout/setColorDarkScheme", val);
    },
    copyText() {
      this.$refs.layout.select();
      document.execCommand("copy");
      this.$toasted.show("Code Copied to clipboard", {
        theme: "outline",
        position: "top-right",
        type: "default",
        duration: 2000,
      });
    },
  },
};
</script>