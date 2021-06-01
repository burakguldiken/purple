<template>
  <div>
    <br><br>
    <div class="container-fluid p-l-50">
      <div class="row">
        <div class="col-4">
          <b-card header-tag="div">
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
                <h6 class="rating"><i class="fa fa-star txt-warning"><span class="m-l-5 fw-600">5.0</span></i></h6>
              </div>
              <div class="text-center m-t-30">
                <b-button id="default-sm-primary" variant="primary" size="sm">Mesaj Gönder</b-button>
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
          <div class="m-t-40">
            <h5 class="f-w-700 m-b-20">Belki İlginizi Çekebilir<i class="txt-primary icofont icofont-job-search m-l-5"></i></h5>
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
        </div>
        <div class="col-8">
          <px-card :actions="false" class="features-faq product-box">
						<div slot="headerCustom">
							<div class="base product-img" style="height:350px">
								<img style="width:100%;height:100%" class="" src="../../assets/images/job-search/backend.png" alt=""/>
							</div>
						</div>
						<div slot="with-padding">
              <div class="row">
                <div class="col-9">
                  <div class="row">
                    <div class="col-12 m-b-10">
                      <h8 class="fw-bold">İlan Açıklaması</h8>
                    </div>
                    <div class="col-12">
									      <h7 class="text-muted">
                          Merhabalar,<br>
                          HTML ile kodlanmış websitenizi rahatlıkla yönetmeniz için PHP ile kodlanmış admin paneli ekleyebilirim.<br>
                          Hakkımda,<br>
                          İletişim,<br>
                          Markalar,<br>
                          Referanslar,<br>
                          Sponsorlar,<br>
                          Makaleler<br>
                          sayfalarınızı panelden yönetme imkanı sunarım.<br><br>

                          Ek olarak ;<br>
                          Üyler,<br>
                          Üye yönetim,<br>
                          Siparişler,<br>
                          Sipariş yönetim sayfaları yapabilirim.<br>
                          Detaylı bilgi için mesaj atabilirsiniz.<br>
                          Lütfen projeyi tartışmadan önce satın alım yapmayın.<br>
                        </h7>
                    </div>
                  </div>
                </div>
              </div>
              <div class="row m-t-40">
                <div class="col-12">
                  <small class="f-w-500">Yayınlanma Tarihi : <span class="txt-success">15 Ocak 2021</span></small><br>
                  <small class="f-w-500">Toplam Başvuru Sayısı : <span>77</span></small><br>
                </div>
              </div>
						</div>
						<div slot="footer">
              <div class="text-right">
                <b-button class="m-r-10" id="default-sm-secondary" variant="secondary" size="sm">İlanı Kaydet<i class="icofont icofont-heart-alt m-l-5"></i></b-button>
                <b-button id="default-sm-primary" variant="primary" size="sm">Başvur<i class="icofont icofont-ui-check m-l-5"></i></b-button>
              </div>
						</div>
					</px-card>
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
