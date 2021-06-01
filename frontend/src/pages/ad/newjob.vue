<template>
  <div>
    <br><br>
      <div class="container-fluid p-l-50">
        <div class="row">
          <div class="col-4">
            <div class="row">
              <b-card header-tag="div" class="shadow-sm">
                <div class="row" slot="header">
                  <div class="col-3">
                    <div class="text-left">
                      <div class="avatars">
                        <div class="avatar"><img class="img-50 rounded-circle shadow-lg" :src='"../../assets/images/dashboard/myimage.jpeg"' alt="#">
                          <div class="status status-100 bg-success"> </div>
                        </div>
                      </div>
                    </div>
                  </div>
                  <div class="col-9 text-left">
                    <small class="text-muted fw-bold">Burak Güldiken</small>
                    <span class="fw-bold txt-success">Cüzdanım</span>
                  </div>
                </div>
                <b-card-text class="text-center news">
                    <i class="icofont icofont-wallet txt-secondary f-100"></i>
                    <p class="f-w-500 m-t-20">Kalan Bakiye : <span class="txt-success">800 PCoin</span></p>
                </b-card-text>
                <div slot="footer" class="text-right">
                  <b-button id="default-sm-secondary" variant="secondary" size="sm">PCoin Yükle<i class="icofont icofont-credit-card m-l-5"></i></b-button>
                </div>
              </b-card>
            </div>
            <div class="row">
              <b-card header-tag="div" class="shadow-sm">
                <div class="row" slot="header">
                  <div class="col-12 text-left">
                    <span class="fw-bold text-muted txt-success">İlanlarım</span>
                  </div>
                </div>
                <b-card-text class="text-center news">
                    <i class="icofont icofont-newspaper f-100 txt-primary"></i>
                    <p class="f-w-500 m-t-20">Toplam İlan Sayınız : <span class="txt-success">3 Adet</span></p>
                </b-card-text>
                <div slot="footer" class="text-right">
                  <b-button id="default-sm-secondary" variant="secondary" size="sm">İlanlarıma Git<i class="icofont icofont-arrow-right m-l-5"></i></b-button>
                </div>
              </b-card>
            </div>
          </div>
          <div class="col-8 p-l-30">
            <px-card :actions="false" class="shadow-sm">
              <div slot="headerCustom">
                <h5 class="fw-bold m-b-20">Yeni Bir İlan Oluşturun<i class="icofont icofont-newspaper m-l-5 txt-primary"></i></h5>
                <span class="f-w-300">Purple arayüzünü kullanarak yeni bir ilan oluşturabilirsiniz.Tek yapmanız gereken aşağıdaki formda ilgili kısımları eksiksiz olarak doldurmanız.
                <span>İlan oluşturmak için <small class="txt-danger fw-bold">100 PCoin</small> gerekmektedir.</span>
                </span>
              </div>
              <div slot="with-padding">
                <b-form class="needs-validation" @submit="onCustomStyleSubmit">
                  <div class="form-row">
                    <div class="col-12 m-b-30">
                      <small class="txt-danger fw-bold">Temel Bilgiler</small>
                    </div>
                    <div class="col-12 m-b-20">
                      <label for="c_form_first_name">İlan Başlığı</label>
                      <b-form-input type="text" id="c_form_first_name" v-model="c_form.first_name" :state="c_form_result.first_name" placeholder="Başlık"></b-form-input>
                      <b-form-valid-feedback :state="c_form_result.first_name">Lock Good</b-form-valid-feedback>
                    </div>
                    <div class="col-12 m-b-20">
                      <label>İlan İçeriği</label>
                      <b-form-textarea id="c_form_last_name" v-model="c_form.last_name" :state="c_form_result.last_name" placeholder="İçerik" rows="15"></b-form-textarea>
                      <b-form-valid-feedback :state="c_form_result.last_name">Lock Good</b-form-valid-feedback>
                    </div>
                  </div>
                  <div class="form-row m-t-30">
                    <div class="col-12 m-b-30">
                      <small class="txt-danger fw-bold">Diğer Bilgiler</small>
                    </div>
                    <div class="col-6 m-b-20">
                      <label for="c_form_city">Adres</label>
                      <b-form-input type="text" id="c_form_city" v-model="c_form.city" :state="c_form_result.city" placeholder="Adres Bilgisi"></b-form-input>
                      <b-form-invalid-feedback :state="c_form_result.city">Please provide a valid city.</b-form-invalid-feedback>
                    </div>
                    <div class="col-6 m-b-20">
                      <label for="c_form_state">Telefon</label>
                      <b-form-input type="text" id="c_form_state" v-model="c_form.state" :state="c_form_result.state" placeholder="Telefon(Opsiyonel)"></b-form-input>
                      <b-form-invalid-feedback :state="c_form_result.state">Please provide a valid state.</b-form-invalid-feedback>
                    </div>
                    <div class="col-6 m-b-20">
                      <label for="c_form_state">Aranan Adaya Ait Cinsiyet</label>
                      <multiselect id="c_form_zipcode" v-model="c_form.zip" :state="c_form_result.zip" :options="options" label="name" :searchable="false" :close-on-select="false" :show-labels="false" placeholder="Cinsiyet"></multiselect>
                    </div>
                    <div class="col-6 m-b-20">
                      <label for="c_form_state">Çalışma Türü</label>
                      <multiselect id="c_form_zipcode" v-model="c_form.zip" :state="c_form_result.zip" :options="options" label="name" :searchable="false" :close-on-select="false" :show-labels="false" placeholder="Çalışma Türü"></multiselect>
                    </div>
                    <div class="col-6 m-b-20">
                      <label for="c_form_state">Sektör</label>
                      <multiselect id="c_form_zipcode" v-model="c_form.zip" :state="c_form_result.zip" :options="options" label="name" :searchable="false" :close-on-select="false" :show-labels="false" placeholder="Sektör"></multiselect>
                    </div>
                  </div>
                  <div class="text-right m-t-30">
                    <b-button type="submit" size="sm" variant="primary">Oluştur<i class="icofont icofont-ui-check m-l-5"></i></b-button>
                  </div>
                </b-form>
              </div>
            </px-card>
          </div>
        </div>
      </div>
  </div>
</template>

<script>
import Multiselect from 'vue-multiselect'
import 'vue2-dropzone/dist/vue2Dropzone.min.css'
import "vue-multiselect/dist/vue-multiselect.min.css"
export default {

  name:'todo',

  components: {
    Multiselect
  },

	data(){
		return{
			email: "",
            supported_form:{
                checkbox:false,
                radio:null,
                selected: null,
                file:null
            },
            supported_form_radio_options: [
              { text: 'Toggle this custom radio', value: 'first' },
              { text: 'Or toggle this other custom radio', value: 'second' }
            ],
            supported_form_select_options: [
              { value: null, text:'Open this select menu' },
              { value: '1', text:'One' },
              { value: '2', text:'Two' },
              { value: '3', text:'Three' },
            ],
            c_form:{
                first_name:'',
                last_name:'',
                username:'',
                city:'',
                state:'',
                zip:''
            },
            c_form_result:{
                first_name:null,
                last_name:null,
                username:null,
                city:null,
                state:null,
                zip:null
            },
            tooltip_form:{
                first_name:'',
                last_name:'',
                username:'',
                city:'',
                state:'',
                zip:''
            },
            tooltip_form_result:{
                first_name:null,
                last_name:null,
                username:null,
                city:null,
                state:null,
                zip:null
            },
            options: [
              {code: 1, name: 'Alabama'},
              {code: 2, name: 'Wyoming'},
              {code: 3, name: 'Coming'},
              {code: 4, name: 'Hanry Die'},
              {code: 5, name: 'John Doe'}
            ],
		}
	},

  computed:{
        supported_checkbox_state(){
            return this.supported_form.checkbox
        },
        supported_radio_state(){
            return Boolean(this.supported_form.radio)
        },
        supported_select_state(){
            if(this.supported_form.selected == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        },
        supported_file_state(){
            if(this.supported_form.file === null)
            {
              return false
            }
            else
            {
              return true
            }
        },
    },
    methods:{
        onCustomStyleSubmit(evt){            
            evt.preventDefault()
            if(this.c_form.first_name != '')
            {
                console.log("custom stylr", this.c_form.first_name);
                this.c_form_result.first_name = true
            }
            else
            {
                this.c_form_result.first_name = false
            }

            if(this.c_form.last_name != '')
            {
                this.c_form_result.last_name = true
            }
            else
            {
                this.c_form_result.last_name = false
            }

            if(this.c_form.username != '')
            {
                this.c_form_result.username = true
            }
            else
            {
                this.c_form_result.username = false
            }

            if(this.c_form.city != '')
            {
                this.c_form_result.city = true
            }
            else
            {
                this.c_form_result.city = false
            }

            if(this.c_form.state != '')
            {
                this.c_form_result.state = true
            }
            else
            {
                this.c_form_result.state = false
            }

            if(this.c_form.zip != '')
            {
                this.c_form_result.zip = true
            }
            else
            {
                this.c_form_result.zip = false
            }
        },

        onTooltipSubmit(evt){
            evt.preventDefault()
            if(this.tooltip_form.first_name != '')
            {
                this.tooltip_form_result.first_name = true
            }
            else
            {
                this.tooltip_form_result.first_name = false
            }

            if(this.tooltip_form.last_name != '')
            {
                this.tooltip_form_result.last_name = true
            }
            else
            {
                this.tooltip_form_result.last_name = false
            }

            if(this.tooltip_form.username != '')
            {
                this.tooltip_form_result.username = true
            }
            else
            {
                this.tooltip_form_result.username = false
            }

            if(this.tooltip_form.city != '')
            {
                this.tooltip_form_result.city = true
            }
            else
            {
                this.tooltip_form_result.city = false
            }

            if(this.tooltip_form.state != '')
            {
                this.tooltip_form_result.state = true
            }
            else
            {
                this.tooltip_form_result.state = false
            }

            if(this.tooltip_form.zip != '')
            {
                this.tooltip_form_result.zip = true
            }
            else
            {
                this.tooltip_form_result.zip = false
            }
        }
    }
}
</script>
