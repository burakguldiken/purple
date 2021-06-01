<template>
  <div>
    <br/><br/>
    <div class="container-fluid p-l-50">
      <div class="row">
        <div class="col-4">
          <b-card header-tag="div" class="shadow-sm">
            <div class="text-right">
              <span class="txt-success fw-bold">Düzenle</span>
            </div>
            <div class="text-center pt-4 pb-5">
              <div class="avatars">
                <div class="avatar"><img class="img-100 rounded-circle shadow-lg" :src='"../../assets/images/dashboard/myimage.jpeg"' alt="#">
                  <div class="status status-100 bg-success"> </div>
                </div>
              </div>
            </div>
            <b-card-text>
              <div class="text-center">
                <h6 class="fw-bold">Burak Güldiken</h6>
                <p class="text-muted">Full-Stack Developer</p>
              </div>
              <div class="text-center m-t-30">
                <span class="f-w-300"><span class="fw-bold">Purple</span>'da profiliniz ne kadar güçlü ise size o kadar daha iyi hizmet sağlayabilmekteyiz.Bu sebeple profilinizdeki bilgiler dahilinde profilinizle eşleşen ilanları size gösterebiliriz.</span>
              </div>
              <div class="text-center m-t-30">
                <b-button id="default-sm-primary" variant="primary" size="sm">İlanlarıma Git</b-button>
              </div>
            </b-card-text>
            <div class="row b-t-light">
              <div class="col-6 m-t-10 text-left">
                <small class="f-w-500">Son Görülme</small>
              </div>
              <div class="col-6 m-t-10 text-right">
                <small class="f-w-500 txt-success">Çevrimiçi</small>
              </div>
              <div class="col-6 m-t-10 text-left">
                <small class="f-w-500">İlan Sayısı</small>
              </div>
              <div class="col-6 m-t-10 text-right">
                <small class="f-w-300">3</small>
              </div>
              <div class="col-6 m-t-10 text-left">
                <small class="f-w-500">Üyelik Tarihi</small>
              </div>
              <div class="col-6 m-t-10 text-right">
                <small class="f-w-300">20 May 2020</small>
              </div>
            </div>
          </b-card>
        </div>
        <div class="col-8">
          <b-card header-tag="div" class="shadow-sm">
            <div class="row m-b-50">
              <div class="col-6 text-left">
                <span class="f-w-600">İlanlarım</span>
              </div>
              <div class="col-6 text-right">
                <span class="txt-success fw-bold">İlanlarımı Görüntüle</span>
              </div>
            </div>
            <b-card-text class="text-center m-t-50">
              <div class="row justify-content-center">
                <div class="col-9">
                  <img class="img-fluid rounded" :src='"../../assets/images/profile-adverb.png"' alt=""/>
                </div>
              </div>
              <div class="row justify-content-center m-t-30">
                <div class="col-8">
                  <h2 class="fw-bold"><span class="f-w-400">İlanlarını </span>Yönet</h2>
                </div>
                <div class="col-10">
                  <h6 class="text-muted f-w-400 m-t-20">Sevgili <span class="fw-bold">Burak</span>, aktif ilanın yok gözüküyor. İlanlarım sayfasından tüm ilanlarını yönetebilirsin.</h6>
                </div>
              </div>
              <div class="row text-center justify-content-center m-t-40">
                <div class="col-4">
                  <b-button id="default-sm-secondary" variant="secondary" size="sm">İlanlarıma Git</b-button>
                </div>
              </div>
            </b-card-text>
          </b-card>
        </div>
      </div>
      <div class="row">
        <div class="col-4">
          <b-card header-tag="div" class="shadow-sm">
            <div class="row" slot="header">
              <div class="col-6 text-left">
                <h6 class="f-w-500">Hakkında</h6>
              </div>
              <div class="col-6 text-right">
                <h7 class="fw-bold txt-success">Düzenle</h7>
              </div>
              <div class="col-12 m-t-20">
                <small class="text-muted f-w-500">Backend tarafında .Net core,RabbitMQ,Redis gibi teknolojiler frontend tarafında ise vue.js ile geliştirmeler yapabilirim.</small>
              </div>
            </div>
            <b-card-text>
              <div class="row m-b-10">
                <h6 class="f-w-500">Uzmanı Olduğu Alanlar & Araçlar</h6>
              </div>
              <div class="row">
                <div class="col-6 text-left m-b-5">
                  <b-button style="pointer-events:none;" id="default-outline-light-md" variant="outline-light" size="md"  class="btn-square btn-outline-light b-r-5 shadow-sm"><small class="text-muted f-w-500">.Net Core</small></b-button>
                </div>
                <div class="col-6 text-left m-b-5">
                  <b-button style="pointer-events:none;" id="default-outline-light-md" variant="outline-light" size="md"  class="btn-square btn-outline-light b-r-5 shadow-sm"><small class="text-muted f-w-500">Dapper</small></b-button>
                </div>
                <div class="col-6 text-left m-b-5">
                  <b-button style="pointer-events:none;" id="default-outline-light-md" variant="outline-light" size="md"  class="btn-square btn-outline-light b-r-5 shadow-sm"><small class="text-muted f-w-500">Vue.js</small></b-button>
                </div>
                <div class="col-6 text-left m-b-5">
                  <b-button style="pointer-events:none;" id="default-outline-light-md" variant="outline-light" size="md"  class="btn-square btn-outline-light b-r-5 shadow-sm"><small class="text-muted f-w-500">Javascript</small></b-button>
                </div>
                <div class="col-6 text-left m-b-5">
                  <b-button style="pointer-events:none;" id="default-outline-light-md" variant="outline-light" size="md"  class="btn-square btn-outline-light b-r-5 shadow-sm"><small class="text-muted f-w-500">RabbitMQ</small></b-button>
                </div>                
              </div>
              <div class="row m-t-40">
                <h6 class="f-w-500">İletişim Bilgileri</h6>
                <div class="row m-t-10">
                  <div class="col-4 text-left">
                    <span class="f-w-500">Email :</span>
                  </div>
                  <div class="col-8 text-center">
                    <small>burakguldiken@test.com</small>
                  </div>
                  <div class="col-4 text-left m-t-10">
                    <span class="f-w-500">Telefon :</span>
                  </div>
                  <div class="col-8 text-center m-t-10">
                    <small>Bulunamadı</small>
                  </div>
                </div>
              </div>
            </b-card-text>
          </b-card>
        </div>
        <div class="col-8">
          <b-card header-tag="div" class="shadow-sm">
            <div class="row m-b-50">
              <div class="col-6 text-left">
                <span class="fw-bold">Değerlendirmeler</span>
              </div>
              <div class="col-6 text-right">
                <b-button id="default-sm-secondary" variant="secondary" size="sm">Yorum Ekle</b-button>
              </div>
            </div>
            <b-card-text class="text-center news">
                <div class="row b-b-light">
                  <div class="col-2 m-b-20">
                    <img class="img-50 rounded-circle shadow-lg" :src='"../../assets/images/user/4.jpg"' alt=""/>
                  </div>
                  <div class="col-10 m-b-20 text-left">
                    <h6 class="fw-bold">Harry Kewell.</h6>
                    <span class="text-muted">.Net tarafında size rahatlıkla yardımcı olabilir</span>
                  </div>
                </div>
                <div class="row m-t-30 b-b-light">
                  <div class="col-2 m-b-20">
                    <img class="img-50 rounded-circle shadow-lg" :src='"../../assets/images/user/1.jpg"' alt=""/>
                  </div>
                  <div class="col-10 m-b-20 text-left">
                    <h6 class="fw-bold">Milan Baros</h6>
                    <span class="text-muted">Kendisiyle çalışmak çok keyifliydi</span>
                  </div>
                </div>
                <div class="row m-t-30 m-b-30 b-b-light">
                  <div class="col-2 m-b-20">
                    <img class="img-50 rounded-circle shadow-lg" :src='"../../assets/images/user/5.jpg"' alt=""/>
                  </div>
                  <div class="col-10 m-b-20 text-left">
                    <h6 class="fw-bold">Abdul Kader Keita</h6>
                    <span class="text-muted">Harika..!</span>
                  </div>
                </div>
                <div slot="footer" class="text-right">
                  <span>Toplam: 5 Yorum</span>
                </div>
            </b-card-text>
          </b-card>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import VueGallery from "vue-gallery";
export default {
  components: {
    VueGallery,
  },
  data() {
    return {
      index: null,
      bigimages: [
        require("../../assets/images/portfolio1.jpg"),
        require("../../assets/images/portfolio2.jpg"),
        require("../../assets/images/portfolio3.jpg"),
        require("../../assets/images/portfolio4.jpg"),
        require("../../assets/images/portfolio5.jpg"),
        require("../../assets/images/portfolio6.jpg"),
        require("../../assets/images/portfolio7.jpg"),
        require("../../assets/images/portfolio8.jpg"),
      ],
      figureslist: [
        {
          title: "Johan Deo",
          descr:
            "is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy.",
          image: "portfolio1.jpg",
        },
        {
          title: "Dev John",
          descr:
            "is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy.",
          image: "portfolio2.jpg",
        },
        {
          title: "Johan Deo",
          descr:
            "is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy.",
          image: "portfolio3.jpg",
        },
        {
          title: "Comeren Diaz",
          descr:
            "is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy.",
          image: "portfolio4.jpg",
        },
        {
          title: "Andew Jon",
          descr:
            "is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy.",
          image: "portfolio5.jpg",
        },
        {
          title: "Sarah Loren",
          descr:
            "is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy.",
          image: "portfolio6.jpg",
        },
        {
          title: "Andew Jon",
          descr:
            "is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy.",
          image: "portfolio7.jpg",
        },
        {
          title: "Bucky Barnes",
          descr:
            "is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy.",
          image: "portfolio8.jpg",
        },
      ],
    };
  },
};
</script>