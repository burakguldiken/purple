<template>
  <div>
    <br><br>
    <div class="container-fluid p-l-50">
      <div class="row">
        <div class="col-7">
          <div class="row">
            <div class="col-2">
              <div class="card-body avatar-showcase">
                <div class="customers d-inline-block avatar-group">
                  <ul>
                    <li class="d-inline-block"><img class="img-100 rounded-circle shadow-lg" :src='"../../assets/images/dashboard/myimage.jpeg"' alt=""></li>
                  </ul>
                </div>
              </div>
            </div>
            <div class="col-10">
              <h2 class="m-l-20 m-t-30 f-w-400">Merhaba,<span class="f-w-700">Burak Güldiken</span></h2>
              <span class="m-l-20">Purple'a tekrar hoş geldin !</span>
            </div>
          </div>
        </div>
        <div class="col-5">
          <b-card header-tag="div">
            <div class="row">
              <div class="col-4">
                <img class="img-70 rounded-circle shadow-lg" :src='"../../assets/images/dashboard/bicoin.svg"' alt=""/>
              </div>
              <div class="col-8">
                <h5>Pcoin'leri Topla</h5>
                <b-card-text class="mb-0">
                  <small>Öncelik, Zaman ve Görünürlük Kazan</small>
                  <p class="txt-success">Detaylı Bilgi</p>
                </b-card-text>
              </div>
            </div>
          </b-card>
        </div>
      </div>
      <div class="row m-l-10 m-t-50">
        <div class="col-4 m-t-30">
          <b-card header-tag="div" class="shadow">
            <div class="pt-1 pb-5 text-center">
              <h5 class="m-l-20 m-t-20 f-w-400">Sana Uygun,<span class="f-w-700">Alıcı İstekleri</span></h5>
            </div>
            <div class="text-center">
              <img :src='"../../assets/images/dashboard/buyer.svg"' alt=""/>
            </div>
            <b-card-text class="m-t-50">
              <p class="text-center f-w-400 text-muted">Sana ve yeteneklerine en uygun alıcı isteklerini gösterebilmemiz için, seni tanımamız lazım.<span class="fw-bold"> Bu yüzden en az 1 adet iş ilanı oluşturmalısın.</span></p>
            </b-card-text>
            <b-card-footer class="text-center m-t-20">
              <b-button id="default-sm-primary" variant="primary" size="sm">Yeni İlan Oluştur</b-button>
            </b-card-footer>
          </b-card>
        </div>
        <div class="col-4 m-t-30">
          <b-card header-tag="div" class="shadow">
            <div class="pt-4 pb-5 text-center">
              <h5 class="m-l-20 f-w-400">Profilini <span class="f-w-700">Güçlendir</span></h5>
            </div>
            <div class="text-center">
              <img class="img-100 rounded-circle shadow-lg m-b-10" :src='"../../assets/images/dashboard/myimage.jpeg"' alt=""/>
            </div>
            <b-card-text>
              <ul class="list-unstyled mb-4">
                <li class="py-2 txt-success"><i class="icofont icofont-check-circled m-r-10"></i>Bilgiler</li>
                <li class="py-2 txt-success"><i class="icofont icofont-check-circled m-r-10"></i>Hakkında</li>
                <li class="py-2 txt-success"><i class="icofont icofont-check-circled m-r-10"></i>Uzmanı Olduğun Araçlar & Alanlar</li>
                <li class="py-2 txt-success"><i class="icofont icofont-check-circled m-r-10"></i>İletişim Bilgileri</li>
              </ul>
            </b-card-text>
            <b-card-footer class="text-center">
              <b-button id="default-sm-primary" variant="primary" size="sm">Profilini Düzenle</b-button>
            </b-card-footer>
          </b-card>
        </div>
        <div class="col-4 m-t-30">
          <b-card header-tag="div" class="shadow">
            <div class="pt-1 pb-5 text-center">
              <h5 class="m-l-20 m-t-25 f-w-400">Purple,<span class="f-w-700">İlanları Görüntüle</span></h5>
            </div>
            <div class="text-center">
              <img width="62%" :src='"../../assets/images/dashboard/home-card.jpg"' alt=""/>
            </div>
            <b-card-text class="m-t-50">
              <p class="text-center f-w-400 text-muted">Purple arayüzünden yeni ilanlar yayınlayabilir veya var olan ilanlara başvurabilirsiniz.<span class="fw-bold">Sizde hemen yeni bir ilan oluşturabilirsiniz.</span></p>
            </b-card-text>
            <b-card-footer class="text-center">
              <b-button id="default-sm-primary" variant="primary" size="sm">İlanları Görüntüle</b-button>
            </b-card-footer>
          </b-card>
        </div>
      </div>
      <div class="row m-l-10 m-t-50">
        <div class="col-12">
          <h5 class="f-w-700">En Yeni İlanlar<i class="icofont icofont-newspaper txt-primary m-l-5"></i></h5>
        </div>
        <div class="row m-t-30">
          <div class="col-5">
            <b-card header-tag="div" class="shadow news text-left">
              <div class="pt-1 pb-5 text-center">
                <h5 class="m-l-20 m-t-10 f-w-700">Purple Üzerindeki En Yeni İlanlar</h5>
              </div>
                <div>
                  <div class="row">
                    <div class="col-2">
                      <img class="img-30 rounded shadow-lg" :src='"../../assets/images/job-search/1.jpg"' alt=""/>
                    </div>
                    <div class="col-10">
                      <h6 class="fw-bold">36% off For pixel lights Couslations Types.</h6>
                      <small clas>Lorem Ipsum is simply dummy...</small>
                    </div>
                  </div>
                  <div class="mt-4" style="border-top:1px solid #dce1e1">
                  </div>
                </div>
                <div>
                  <div class="row m-t-30">
                    <div class="col-2">
                      <img class="img-30 rounded shadow-lg" :src='"../../assets/images/job-search/2.jpg"' alt=""/>
                    </div>
                    <div class="col-10">
                      <h6 class="fw-bold">36% off For pixel lights Couslations Types.</h6>
                      <small>Lorem Ipsum is simply dummy...</small>
                    </div>
                  </div>
                  <div class="mt-4" style="border-top:1px solid #dce1e1">
                  </div>
                </div>
                <div>
                  <div class="row m-t-30 m-b-30">
                    <div class="col-2">
                      <img class="img-30 rounded shadow-lg" :src='"../../assets/images/job-search/4.jpg"' alt=""/>
                    </div>
                    <div class="col-10">
                      <h6 class="fw-bold">36% off For pixel lights Couslations Types.</h6>
                      <small>Lorem Ipsum is simply dummy...</small>
                    </div>
                  </div>
                </div>
              <b-card-footer class="text-center">
                <b-button id="default-sm-primary" variant="primary" size="sm">Tümünü Görüntüle</b-button>
              </b-card-footer>
            </b-card>
          </div>
          <div class="col-7">
            <div class="row">
              <div class="col-12">
                <b-card class="shadow invoice-info">
                  <b-card-text class="text-right">
                    <b-button id="default-lg-primary" variant="primary" size="lg" class="text-center">Freelancer Fatura Nasıl Kesilir ?</b-button>
                  </b-card-text>
                </b-card>
              </div>
              <div class="col-12">
                <b-card class="shadow purple-detail bottom">
                  <b-card-text class="text-right">
                    <b-button id="default-lg-primary" variant="primary" size="lg" class="text-center">Purple Nasıl Çalışır ?</b-button>
                  </b-card-text>
                </b-card>
              </div>
            </div>
          </div>
        </div>
        <div class="row m-t-50">
          <h5 class="f-w-700">En Çok Görüntülenen İlanlar<i class="txt-primary icofont icofont-job-search m-l-5"></i></h5>
          <div class="row m-t-30">
            <div class="col-4">
              <px-card :actions="false" class="features-faq product-box">
								<div slot="headerCustom">
                  <div class="base product-img" style="height:200px">
                    <img style="width:100%;height:100%" src="../../assets/images/job-search/frontend.jpg" alt=""/>
                  </div>
								</div>
								<div slot="with-padding">
                  <div class="row">
                    <div class="col-3">
                      <img class="img-50 rounded-circle shadow-lg m-b-10" :src='"../../assets/images/dashboard/myimage.jpeg"' alt=""/>
                    </div>
                    <div class="col-9">
                      <h7 class="fw-bold">Frontend Developer</h7><br>
                      <small>Burak Güldiken Yayınlandı</small>
                    </div>
                  </div>
								</div>
								<div slot="footer">
                  <span>17 Mayıs 2021</span>
                  <span class="pull-right">
                    <i class="icofont icofont-eye-alt"><small class="text-muted m-l-5">75 Görüntüleme</small></i>
                  </span>
								</div>
							</px-card>
            </div>
            <div class="col-4">
              <px-card :actions="false" class="features-faq product-box">
								<div slot="headerCustom">
                  <div class="base product-img" style="height:200px">
                    <img style="width:100%;height:100%" class="" src="../../assets/images/job-search/ios.png" alt=""/>
                  </div>
								</div>
								<div slot="with-padding">
                  <div class="row">
                    <div class="col-3">
                      <img class="img-50 rounded-circle shadow-lg m-b-10" :src='"../../assets/images/dashboard/myimage.jpeg"' alt=""/>
                    </div>
                    <div class="col-9">
                      <h7 class="fw-bold">İOS Developer</h7><br>
                      <small>Burak Güldiken Yayınlandı</small>
                    </div>
                  </div>
								</div>
								<div slot="footer">
                  <span>17 Mayıs 2021</span>
                  <span class="pull-right">
                    <i class="icofont icofont-eye-alt"><small class="text-muted m-l-5">55 Görüntüleme</small></i>
                  </span>
								</div>
							</px-card>
            </div>
            <div class="col-4">
              <px-card :actions="false" class="features-faq product-box">
								<div slot="headerCustom">
                  <div class="base product-img" style="height:200px">
                    <img style="width:100%;height:100%" src="../../assets/images/job-search/dotnet.jpg" alt=""/>
                  </div>
								</div>
								<div slot="with-padding">
                  <div class="row">
                    <div class="col-3">
                      <img class="img-50 rounded-circle shadow-lg m-b-10" :src='"../../assets/images/dashboard/myimage.jpeg"' alt=""/>
                    </div>
                    <div class="col-9">
                      <h7 class="fw-bold">.Net Core Developer</h7><br>
                      <small>Burak Güldiken Yayınlandı</small>
                    </div>
                  </div>
								</div>
								<div slot="footer">
                  <span>17 Mayıs 2021</span>
                  <span class="pull-right">
                    <i class="icofont icofont-eye-alt"><small class="text-muted m-l-5">70 Görüntüleme</small></i>
                  </span>
								</div>
							</px-card>
            </div>
          </div>
        </div>
        <div class="row m-t-50">
          <h5 class="f-w-700">Sana Ait İlanlar<i class="txt-primary icofont icofont-worker m-l-5"></i></h5>
          <div class="row m-t-30">
            <div class="col-4">
              <px-card :actions="false" class="features-faq product-box">
								<div slot="headerCustom">
                  <div class="base product-img" style="height:200px">
                    <img style="width:100%;height:100%" src="../../assets/images/job-search/java.png" alt=""/>
                  </div>
								</div>
								<div slot="with-padding">
                  <div class="row">
                    <div class="col-3">
                      <img class="img-50 rounded-circle shadow-lg m-b-10" :src='"../../assets/images/dashboard/myimage.jpeg"' alt=""/>
                    </div>
                    <div class="col-9">
                      <h7 class="fw-bold">Java Developer</h7><br>
                      <small>Burak Güldiken Yayınlandı</small>
                    </div>
                  </div>
								</div>
								<div slot="footer">
                  <span>17 Mayıs 2021</span>
                  <span class="pull-right">
                    <i class="icofont icofont-eye-alt"><small class="text-muted m-l-5">3 Görüntüleme</small></i>
                  </span>
								</div>
							</px-card>
            </div>
            <div class="col-4">
              <px-card :actions="false" class="features-faq product-box">
								<div slot="headerCustom">
                  <div class="base product-img" style="height:200px">
                    <img style="width:100%;height:100%" class="" src="../../assets/images/job-search/fullstack.jpg" alt=""/>
                  </div>
								</div>
								<div slot="with-padding">
                  <div class="row">
                    <div class="col-3">
                      <img class="img-50 rounded-circle shadow-lg m-b-10" :src='"../../assets/images/dashboard/myimage.jpeg"' alt=""/>
                    </div>
                    <div class="col-9">
                      <h7 class="fw-bold">Full-Stack Developer</h7><br>
                      <small>Burak Güldiken Yayınlandı</small>
                    </div>
                  </div>
								</div>
								<div slot="footer">
                  <span>17 Mayıs 2021</span>
                  <span class="pull-right">
                    <i class="icofont icofont-eye-alt"><small class="text-muted m-l-5">8 Görüntüleme</small></i>
                  </span>
								</div>
							</px-card>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {

    }
  },
};
</script>
