<template>
  <main class="main" id="top">
      <nav class="navbar navbar-expand-lg navbar-light fixed-top py-3" data-navbar-on-scroll="data-navbar-on-scroll">
        <div class="container">
          <a class="navbar-brand d-flex align-items-center fw-bold fs-2" href="index.html">
            <div class="text-purple">Pur</div>
            <div class="text-1000">ple</div>
          </a>
          <button class="navbar-toggler collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation"><span class="navbar-toggler-icon"></span></button>
          <div class="collapse navbar-collapse border-top border-lg-0 mt-4 mt-lg-0" id="navbarSupportedContent" style="border:0 !important">
            <ul class="navbar-nav ms-auto pt-2 pt-lg-0">
              <li class="nav-item" data-anchor="data-anchor"><a class="nav-link fw-medium active" aria-current="page" href="#home">Genel</a></li>
              <li class="nav-item" data-anchor="data-anchor"><a class="nav-link fw-medium text-dark" href="#features">Özellikler</a></li>
              <li class="nav-item" data-anchor="data-anchor"><a class="nav-link fw-medium text-dark" style="color:black" href="#pricing">Fiyatlandırma</a></li>
              <li class="nav-item" data-anchor="data-anchor"><a class="nav-link fw-medium text-dark" href="#testimonial">Hakkımızda</a></li>
            </ul>
            <form class="ps-lg-5">
              <button class="btn btn-lg btn-primary rounded-pill order-0" type="submit" @click="goLoginPage">Başlayalım</button>
            </form>
          </div>
        </div>
      </nav>
      <section class="py-0" id="home">
        <div class="bg-holder firstSection">
        </div>

        <div class="container position-relative">
          <div class="row align-items-center py-8">
            <div class="col-md-5 col-lg-6 col-xl-4 order-md-1 text-center text-md-end"><img class="img-fluid" src="../../assets/images/illustrations/mobile.png" width="350" alt="" /></div>
            <div class="col-md-7 col-lg-6 col-xl-8 text-center text-md-start" style="text-align:left !important"><span class="badge bg-light rounded-pill text-dark align-items-center d-flex flex-row-reverse justify-content-end mx-auto mx-md-0 ps-0 w-75 w-sm-50 w-md-75 w-xl-50 mb-3">Purple Freelance İş Topluluğu<img class="img-fluid float-start me-3" src="../../assets/images/illustrations/arrow-right.png" alt=""/></span>
              <h1 class="mb-4 display-5 fw-bold lh-sm">Hemen yeni bir ilan oluşturun ve<br class="d-block d-lg-none d-xl-block" />Freelancer topluluğundaki yerinizi alın</h1>
              <p class="mt-3 mb-4 fs-1">Yeni ilanlar oluşturabilir ya da <br class="d-none d-lg-block" />var olan ilanlara başvurabilirsiniz.</p><a class="btn btn-lg btn-primary rounded-pill hover-top" href="#" role="button" @click="goLoginPage">Giriş Yap</a><a class="btn btn-link ps-md-4" href="#" role="button" @click="goRegisterPage"> Kayıt Ol</a>
            </div>
          </div>
        </div>
      </section>

      <section class="py-7">

        <div class="container">
          <div class="row">
            <div class="col-12 mx-auto align-items-center text-center">
              <p class="mb-4">Trusted by companies like</p>
            </div>
          </div>
          <div class="row align-items-center justify-content-center justify-content-lg-around">
            <div class="col-6 col-sm-4 col-md-4 col-lg-2 px-md-0 mb-5 mb-lg-0 text-center"><img src="../../assets/images/gallery/company-1.png" alt="" /></div>
            <div class="col-6 col-sm-4 col-md-4 col-lg-2 px-md-0 mb-5 mb-lg-0 text-center"><img src="../../assets/images/gallery/company-2.png" alt="" /></div>
            <div class="col-6 col-sm-4 col-md-4 col-lg-2 px-md-0 mb-5 mb-lg-0 text-center"><img src="../../assets/images/gallery/company-3.png" alt="" /></div>
            <div class="col-6 col-sm-4 col-md-4 col-lg-2 px-md-0 mb-5 mb-lg-0 text-center"><img src="../../assets/images/gallery/company-4.png" alt="" /></div>
            <div class="col-6 col-sm-4 col-md-4 col-lg-2 px-md-0 mb-5 mb-lg-0 text-center"><img src="../../assets/images/gallery/company-1.png" alt="" /></div>
          </div>
        </div>

      </section>

      <section class="py-5" id="features">
        <div class="container-lg">
          <div class="row align-items-center">
            <div class="col-md-5 col-lg-6 order-md-0 text-center text-md-start"><img class="img-fluid" src="../../assets/images/illustrations/feature-bg.png" width="550" alt="" /></div>
            <div class="col-md-7 col-lg-6 px-sm-5 px-md-0">
              <h6 class="fw-bold fs-4 display-3 lh-sm">Purple Arayüzünün<br />Özellikleri</h6>
              <p class="my-4">Purple arayüzü kullanıcılarına birçok<br class="d-none d-xl-block" />özellik sunmaktadır.</p>
              <div class="d-flex align-items-center mb-5">
                <div><img class="img-fluid" src="../../assets/images/illustrations/fast-performance.png" width="90" alt="" /></div>
                <div class="px-4">
                  <h5 class="fw-bold text-danger">Chat</h5>
                  <p>İlanınıza başvuran kişilere<br class="d-none d-xl-block"> mesaj atarak anlık olarak <br class="d-none d-xl-block"> iletişime başlayabilirsiniz.</p>
                </div>
              </div>
              <div class="d-flex align-items-center mb-5">
                <div><img class="img-fluid" src="../../assets/images/illustrations/prototype.png" width="90" alt="" /></div>
                <div class="px-4">
                  <h5 class="fw-bold text-primary">Takvim</h5>
                  <p>Arayüzde bulunan takvim <br class="d-none d-xl-block">ekranında işlerinizi planlayabilir<br class="d-none d-xl-block">ve düzenleyebilirsiniz.</p>
                </div>
              </div>
              <div class="d-flex align-items-center mb-5">
                <div><img class="img-fluid" src="../../assets/images/illustrations/vector.png" width="90" alt="" /></div>
                <div class="px-4">
                  <h5 class="fw-bold text-success">İş Takibi</h5>
                  <p>Kendinize veya beraber çalıştığınız<br class="d-none d-xl-block">kişilere görev atamaları yaparak <br class="d-none d-xl-block"> iş süreçlerinizi yönetebilirsiniz.</p>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>

      <section class="py-5">

        <div class="container">
          <div class="row align-items-center mb-6">
            <div class="col-md-5 col-lg-4 offset-lg-1">
              <h1 class="fw-bold lh-base">Binlerce Kullanıcıya Anında Ulaşın</h1>
            </div>
            <div class="col-md-6 col-lg-5 offset-lg-1 border-start py-5 ps-5">
              <p class="mb-0">Purple freelancer iş topluluğu çok sayıda kullanıcı tarafından tercih edilmektedir.Bu sayede aradığınız ilanlara hızlıca ulaşabilirsiniz.Yayınlanan ilanlarınız çok sayıda kişiye hızlı bir şekilde ulaşabilir.</p>
            </div>
          </div>
          <div class="row">
            <div class="col-md-4 col-lg-3 offset-lg-1 mb-4">
              <div class="py-4"><img class="img-fluid" src="../../assets/images/illustrations/automatic.png" width="90" alt="" /></div>
              <h5 class="fw-bold text-danger">Yüksek Performans</h5>
              <p class="mt-2 mb-0">Purple freelancer arayüzü kullanıcı deneyimi olarak hızlı bir altyapıya sahiptir.</p>
            </div>
            <div class="col-md-4 col-lg-3 offset-lg-1 mb-4">
              <div class="py-4"><img class="img-fluid" src="../../assets/images/illustrations/network.png" width="90" alt="" /></div>
              <h5 class="fw-bold text-primary">Responsive Yapı</h5>
              <p class="mt-2 mb-0">Esnek kullanıcı modülleri sayesinde telefonlarınızdan da kullanmaya devam edebilirsiniz.</p>
            </div>
            <div class="col-md-4 col-lg-3 offset-lg-1 mb-4">
              <div class="py-4"><img class="img-fluid" src="../../assets/images/illustrations/rewards.png" width="90" alt="" /></div>
              <h5 class="fw-bold text-success">Ödül Yapısı</h5>
              <p class="mt-2 mb-0">Purple yapısında kullanıcı perfomansları baz alınarak ödellendirme sistemleri bulunmaktadır.</p>
            </div>
          </div>
        </div>
      </section>

      <section class="py-6">

        <div class="container">
          <div class="row align-items-center">
            <div class="col-md-5 order-md-0 text-center text-md-start"><img class="img-fluid mb-4" src="../../assets/images/illustrations/call-to-action.png" width="550" alt="" /></div>
            <div class="col-md-6 text-center text-md-start offset-md-1">
              <h6 class="fw-bold fs-4 display-3 lh-sm">İlanlar ve Başvurular<br /></h6>
              <p class="my-4 pe-xl-5">Kullanıcılar dilediği kadar ilana başvurabilmektedir.İlan yayınlamak için aşağıdaki fiyatlandırma ekranından daha detaylı bilgilere ulaşabilirsiniz.</p><a class="btn btn-lg btn-primary rounded-pill hover-top" href="#" role="button" @click="goLoginPage">Başlayalım</a>
            </div>
          </div>
        </div>
      </section>

      <section class="py-6">

        <div class="container">
          <div class="row justify-content-center mb-6">
            <div class="col-lg-6 text-center mx-auto mb-3 mb-md-5 mt-4">
              <h6 class="fw-bold fs-4 display-3 lh-sm">Neden Purple ? </h6>
              <p class="mb-0">Purple yapısında çok sayıda özellik bulunmaktadır.Bunlar aşağıda belirtilmiştir.</p>
            </div>
          </div>
          <div class="row">
            <div class="col-md-4 mb-6">
              <div class="text-center px-lg-3"><img class="img-fluid mb-3" src="../../assets/images/illustrations/app.png" width="90" alt="" />
                <h5 class="fw-bold">Bakım</h5>
                <p class="mb-md-0">Arayüz periyodik olarak bakıma alınıp kullanıcı arayüzü açısından geliştirilmekte ve kullanıcılara daha iyi bir deneyim yaşatma imkanı sunmaktadır.</p>
              </div>
            </div>
            <div class="col-md-4 mb-6">
              <div class="text-center px-lg-3"><img class="img-fluid mb-3" src="../../assets/images/illustrations/time-award.png" width="90" alt="" />
                <h5 class="fw-bold">Ödüllendirme Sistemi</h5>
                <p class="mb-md-0">Ay içerisinde 3 veya daha fazla ilan yayınlayan kullanıcılara diğer ay ücretlendirme tutarında %10 indirim sağlanmaktadır.</p>
              </div>
            </div>
            <div class="col-md-4 mb-6">
              <div class="text-center px-lg-3"><img class="img-fluid mb-3" src="../../assets/images/illustrations/cloud.png" width="90" alt="" />
                <h5 class="fw-bold">İlan Öne Çıkarma</h5>
                <p class="mb-md-0">Çok fazla sayıda ilana sahip kişilere ait ilanlar en üst sıralarda gözükmekte ve kullanıcılara daha rahat bir şekilde erişim sağlamaktadır.</p>
              </div>
            </div>
            <div class="col-md-4 mb-6">
              <div class="text-center px-lg-3"><img class="img-fluid mb-3" src="../../assets/images/illustrations/customization.png" width="90" alt="" />
                <h5 class="fw-bold">Özelleştirme</h5>
                <p class="mb-md-0">Kullanıcı arayüzünü kendi istediğiniz şekilde düzenleyebilirsiniz.</p>
              </div>
            </div>
            <div class="col-md-4 mb-6">
              <div class="text-center px-lg-3"><img class="img-fluid mb-3" src="../../assets/images/illustrations/ux.png" width="90" alt="" />
                <h5 class="fw-bold">Çoklu Dil Desteği</h5>
                <p class="mb-md-0">Purple sağladığı çoklu dil desteği özelliği ile kullanıcılara daha iyi bir kullanım ortamı sağlamaktadır.</p>
              </div>
            </div>
            <div class="col-md-4 mb-6">
              <div class="text-center px-lg-3"><img class="img-fluid mb-3" src="../../assets/images/illustrations/support.png" width="90" alt="" />
                <h5 class="fw-bold">Müşteri Desteği</h5>
                <p class="mb-md-0">Karşılaşılan problemlere 7/24 destek verilmektedir.Tek yapmanız gerek ise yeni bir ticket oluşturmak.</p>
              </div>
            </div>
          </div>
        </div>
      </section>

      <section class="py-6">
        <div class="container">
          <div class="container">
            <div class="row align-items-center">
              <div class="col-md-5 order-md-1 text-center text-md-start"><img class="img-fluid mb-4" src="../../assets/images/illustrations/ultimate-feature.png" alt="" /></div>
              <div class="col-md-6 text-center text-md-start">
                <h6 class="fw-bold fs-4 display-3 lh-sm">Purple Arayüzü<br />Özellikleri</h6>
                <p class="my-4 pe-xl-5">Purple Takvim,Chat,İş Planlama gibi ücretsiz özelliklere sahiptir.</p>
                <div class="row">
                  <div class="col-md-6">
                    <div class="mb-4">
                      <div class="py-4"><img class="img-fluid" src="../../assets/images/illustrations/app.png" width="90" alt="" /></div>
                      <h5 class="fw-bold text-undefined">Chat</h5>
                      <p class="mt-2 mb-0">Paketiniz dahilindeki PCoin'ler ile kullanıcılara mesaj gönderebilir veya alabilirsiniz.Her başlatılan sohbet başına 30 PCoin'dir</p>
                    </div>
                  </div>
                  <div class="col-md-6">
                    <div class="mb-4">
                      <div class="py-4"><img class="img-fluid" src="../../assets/images/illustrations/ux.png" width="90" alt="" /></div>
                      <h5 class="fw-bold text-undefined">Takvim</h5>
                      <p class="mt-2 mb-0">İşlerinizi daha iyi planlamak için takvim özelliğini kullanabilirsiniz.Herhangi bir ücretlendirme kuralı bulunmamaktadır.</p>
                    </div>
                  </div>
                  <div class="col-md-6">
                    <div class="mb-4">
                      <div class="py-4"><img class="img-fluid" src="../../assets/images/illustrations/cloud.png" width="90" alt="" /></div>
                      <h5 class="fw-bold text-undefined">İş Planlama</h5>
                      <p class="mt-2 mb-0">Kullanıcıları iş planlama sisteminize dahil edebilir ve birbirinize görev atamaları yapabilirsiniz.</p>
                    </div>
                  </div>
                  <div class="col-md-6">
                    <div class="mb-4">
                      <div class="py-4"><img class="img-fluid" src="../../assets/images/illustrations/support.png" width="90" alt="" /></div>
                      <h5 class="fw-bold text-undefined">Sıkça Sorulan Sorular</h5>
                      <p class="mt-2 mb-0">Arayüzde yer alan sıkça sorulan sorular kısmından karşılaştığınız bazı problemlere çözüm getirebilirsiniz.</p>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>

      <section class="py-8" id="pricing">
        <div class="container">
          <div class="row justify-content-center">
            <div class="col-md-8 col-lg-6 col-xxl-5 text-center mb-3">
              <h6 class="fw-bold fs-4 display-3 lh-sm mb-3">Purple Fiyatlandırmaları</h6>
              <p class="mb-4">Purple paketlerine ait içerikler aşağıda gösterilmiştir.</p>
            </div>
          </div>
          <div class="row flex-center">
            <div class="col-lg-4">
              <div class="card shadow-lg mb-4 border-0">
                <div class="card-header border-bottom-0 pt-7 pb-5">
                  <div class="d-flex justify-content-center">
                    <h1 class="fw-bold">$5</h1><span class="d-flex align-items-center">/aylık</span>
                  </div>
                  <h5 class="fw-bold text-center">Standart</h5><span class="text-700 text-center d-block">Bireysel Kullanıcılar İçin Tavsiye Edilir</span>
                </div>
                <div class="card-body mx-auto">
                  <ul class="list-unstyled mb-4">
                    <li class="text-700 py-2 text-secondary">Aylık 500 PCoin</li>
                    <li class="text-700 py-2 text-secondary">Aylık 3 İlan Yayınlama Hakkı</li>
                    <li class="text-700 py-2 text-secondary">Takvim Özelliği Ücretsiz</li>
                    <li class="text-700 py-2 text-secondary">7/24 Destek</li>
                  </ul><a class="btn btn-lg btn-primary rounded-pill mb-3" @click="goRegisterPage">Şimdi Kayıt Olun</a>
                </div>
              </div>
            </div>
            <div class="col-lg-4">
              <div class="card shadow-lg mb-4 border-0">
                <div class="card-header border-bottom-0 pt-7 pb-5">
                  <div class="d-flex justify-content-center">
                    <h1 class="fw-bold">$15</h1><span class="d-flex align-items-center">/aylık</span>
                  </div>
                  <h5 class="fw-bold text-center">Bronz</h5><span class="text-700 text-center d-block">Kurumlar İçin Tavsiye Edilir</span>
                </div>
                <div class="card-body mx-auto">
                  <ul class="list-unstyled mb-4">
                    <li class="text-700 py-2 text-secondary">Aylık 1500 PCoin</li>
                    <li class="text-700 py-2 text-secondary">Aylık 10 İlan Yayınlama Hakkı</li>
                    <li class="text-700 py-2 text-secondary">Takvim Özelliği Ücretsiz</li>
                    <li class="text-700 py-2 text-secondary">7/24 Destek</li>
                  </ul><a class="btn btn-lg btn-primary rounded-pill mb-3" @click="goRegisterPage">Şimdi Kayıt Olun</a>
                </div>
              </div>
            </div>
            <div class="col-lg-4">
              <div class="card shadow-lg mb-4 border-0">
                <div class="card-header border-bottom-0 pt-7 pb-5">
                  <div class="d-flex justify-content-center">
                    <h1 class="fw-bold">$50</h1><span class="d-flex align-items-center">/yıllık</span>
                  </div>
                  <h5 class="fw-bold text-center">Premium</h5><span class="text-700 text-center d-block">Geniş Topluluklar İçin Tavsiye Edilir</span>
                </div>
                <div class="card-body mx-auto">
                  <ul class="list-unstyled mb-4">
                    <li class="text-700 py-2 text-secondary">Sınırsız PCoin</li>
                    <li class="text-700 py-2 text-secondary">Aylık 20 İlan Yayınlama Hakkı</li>
                    <li class="text-700 py-2 text-secondary">Takvim Özelliği Ücretsiz</li>
                    <li class="text-700 py-2 text-secondary">7/24 Destek</li>
                  </ul><a class="btn btn-lg btn-primary rounded-pill mb-3" @click="goRegisterPage">Şimdi Kayıt Olun</a>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>

      <section class="py-8" id="testimonial">
        <div class="container-lg">
          <div class="row flex-center">
            <div class="col-sm-10 col-md-5 col-lg-5 order-md-0 text-center text-md-start"><img class="img-fluid mb-4" src="../../assets/images/illustrations/testimonial.png" alt="" /></div>
            <div class="col-sm-10 col-md-6 col-lg-6 text-center text-md-start offset-md-1">
              <h6 class="fw-bold fs-4 display-3 lh-sm"> Hakkımızda</h6>
              <p class="my-4 pe-xl-5"> Purple freelancer bir iş topluluğudur.2021 Haziran ayında Burak Güldiken tarafından kurulmuştur.</p>
              <div class="carousel slide" id="carouselExampleDark" data-bs-ride="carousel">
                <div class="carousel-inner">
                  <div class="carousel-item active" data-bs-interval="10000">
                    <div class="row h-100">
                      <div class="col-12">
                        <svg class="bi bi-star-fill" xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="#FFCC00" viewBox="0 0 16 16">
                          <path d="M3.612 15.443c-.386.198-.824-.149-.746-.592l.83-4.73L.173 6.765c-.329-.314-.158-.888.283-.95l4.898-.696L7.538.792c.197-.39.73-.39.927 0l2.184 4.327 4.898.696c.441.062.612.636.283.95l-3.523 3.356.83 4.73c.078.443-.36.79-.746.592L8 13.187l-4.389 2.256z"></path>
                        </svg>
                        <svg class="bi bi-star-fill" xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="#FFCC00" viewBox="0 0 16 16">
                          <path d="M3.612 15.443c-.386.198-.824-.149-.746-.592l.83-4.73L.173 6.765c-.329-.314-.158-.888.283-.95l4.898-.696L7.538.792c.197-.39.73-.39.927 0l2.184 4.327 4.898.696c.441.062.612.636.283.95l-3.523 3.356.83 4.73c.078.443-.36.79-.746.592L8 13.187l-4.389 2.256z"></path>
                        </svg>
                        <svg class="bi bi-star-fill" xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="#FFCC00" viewBox="0 0 16 16">
                          <path d="M3.612 15.443c-.386.198-.824-.149-.746-.592l.83-4.73L.173 6.765c-.329-.314-.158-.888.283-.95l4.898-.696L7.538.792c.197-.39.73-.39.927 0l2.184 4.327 4.898.696c.441.062.612.636.283.95l-3.523 3.356.83 4.73c.078.443-.36.79-.746.592L8 13.187l-4.389 2.256z"></path>
                        </svg>
                        <svg class="bi bi-star-fill" xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="#FFCC00" viewBox="0 0 16 16">
                          <path d="M3.612 15.443c-.386.198-.824-.149-.746-.592l.83-4.73L.173 6.765c-.329-.314-.158-.888.283-.95l4.898-.696L7.538.792c.197-.39.73-.39.927 0l2.184 4.327 4.898.696c.441.062.612.636.283.95l-3.523 3.356.83 4.73c.078.443-.36.79-.746.592L8 13.187l-4.389 2.256z"></path>
                        </svg>
                        <svg class="bi bi-star-fill" xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="#FFCC00" viewBox="0 0 16 16">
                          <path d="M3.612 15.443c-.386.198-.824-.149-.746-.592l.83-4.73L.173 6.765c-.329-.314-.158-.888.283-.95l4.898-.696L7.538.792c.197-.39.73-.39.927 0l2.184 4.327 4.898.696c.441.062.612.636.283.95l-3.523 3.356.83 4.73c.078.443-.36.79-.746.592L8 13.187l-4.389 2.256z"></path>
                        </svg>
                        <h5 class="my-4 fw-bold lh-sm">Genel Yapısı</h5>
                        <p class="mb-0 text-center text-md-start">Purple platformu kişilerin daha kolay ve vakit kaybetmeden işlerini başka kişilerle iletişime geçip yaptırması üzerine kurulmuş bir platformdur.Bu düşüncede yerel ve global alanda hizmet vermektedir.</p>
                      </div>
                      <div class="col-xl-12 pt-4 d-flex d-sm-block text-center">
                        <div class="d-flex align-items-md-center"><img class="img-fluid me-4 me-md-3 me-lg-4" style="margin:auto" src="../../assets/images/gallery/user.png" width="100" alt="" />
                          <div class="w-lg-50 my-3" style="text-align:left">
                            <h5 class="mb-0 fw-bold">Burak Güldiken</h5>
                            <p class="fw-normal mb-0">Purple İş Topluluğu Kurucusu</p>
                          </div>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>

      <section class="py-6">
        <hr />
        <div class="container">
          <div class="row align-items-center">
            <div class="col-md-5 col-lg-7 order-md-1 text-center text-md-start z-index-2 cta-image"><img class="img-fluid mb-4 mb-md-0" src="../../assets/images/illustrations/cta.png" width="850" alt="" /></div>
            <div class="col-md-7 col-lg-5 text-center text-md-start">
              <h1 class="display-3 fw-bold lh-sm">Çok yakında App Store'da</h1>
              <p class="my-4">Gelişmeler buradan yayınlanacaktır.</p>
              <div class="d-flex justify-content-center d-md-inline-block"><a class="pe-2 pe-sm-3 pe-md-4" href="!#"><img src="../../assets/images/illustrations/google-play.png" width="160" alt="" /></a><a href="!#"><img src="../../assets/images/illustrations/app-store.png" width="160" alt="" /></a></div>
            </div>
          </div>
        </div>
      </section>

      <section class="py-8 bg-1000">
        <div class="container">
          <div class="row flex-center">
            <div class="col-auto mb-5"><a class="pe-2 d-flex align-items-center text-decoration-none fw-bold fs-3" href="#">
                <div class="text-purple">Pur</div>
                <div class="text-white">ple</div>
              </a></div>
          </div>
          <div class="row flex-center">
            <div class="col-auto mb-5">
              <ul class="list-unstyled list-inline mb-0">
                <li class="list-inline-item me3 me-sm-4"><a class="text-light text-decoration-none" href="#home">Genel</a></li>
                <li class="list-inline-item me3 me-sm-4"><a class="text-light text-decoration-none" href="#features">Özellikler</a></li>
                <li class="list-inline-item me3 me-sm-4"><a class="text-light text-decoration-none" href="#pricing">Fiyatlandırma</a></li>
                <li class="list-inline-item me3 me-sm-4"><a class="text-light text-decoration-none" href="#testimonial">Hakkımızda</a></li>
              </ul>
            </div>
          </div>
          <div class="row flex-center">
            <div class="col-auto mb-5">
              <ul class="list-unstyled list-inline">
                <li class="list-inline-item me-3"><a class="text-decoration-none" href="#!">
                    <svg class="bi bi-facebook" xmlns="http://www.w3.org/2000/svg" width="32" height="32" fill="#7D7987" viewBox="0 0 16 16">
                      <path d="M16 8.049c0-4.446-3.582-8.05-8-8.05C3.58 0-.002 3.603-.002 8.05c0 4.017 2.926 7.347 6.75 7.951v-5.625h-2.03V8.05H6.75V6.275c0-2.017 1.195-3.131 3.022-3.131.876 0 1.791.157 1.791.157v1.98h-1.009c-.993 0-1.303.621-1.303 1.258v1.51h2.218l-.354 2.326H9.25V16c3.824-.604 6.75-3.934 6.75-7.951z"></path>
                    </svg></a></li>
                <li class="list-inline-item me-3"><a href="#!">
                    <svg class="bi bi-twitter" xmlns="http://www.w3.org/2000/svg" width="32" height="32" fill="#7D7987" viewBox="0 0 16 16">
                      <path d="M5.026 15c6.038 0 9.341-5.003 9.341-9.334 0-.14 0-.282-.006-.422A6.685 6.685 0 0 0 16 3.542a6.658 6.658 0 0 1-1.889.518 3.301 3.301 0 0 0 1.447-1.817 6.533 6.533 0 0 1-2.087.793A3.286 3.286 0 0 0 7.875 6.03a9.325 9.325 0 0 1-6.767-3.429 3.289 3.289 0 0 0 1.018 4.382A3.323 3.323 0 0 1 .64 6.575v.045a3.288 3.288 0 0 0 2.632 3.218 3.203 3.203 0 0 1-.865.115 3.23 3.23 0 0 1-.614-.057 3.283 3.283 0 0 0 3.067 2.277A6.588 6.588 0 0 1 .78 13.58a6.32 6.32 0 0 1-.78-.045A9.344 9.344 0 0 0 5.026 15z"></path>
                    </svg></a></li>
                <li class="list-inline-item me-3"><a href="#!">
                    <svg class="bi bi-hash" xmlns="http://www.w3.org/2000/svg" width="32" height="32" fill="#ffffff" viewBox="0 0 16 16">
                      <path d="M8.39 12.648a1.32 1.32 0 0 0-.015.18c0 .305.21.508.5.508.266 0 .492-.172.555-.477l.554-2.703h1.204c.421 0 .617-.234.617-.547 0-.312-.188-.53-.617-.53h-.985l.516-2.524h1.265c.43 0 .618-.227.618-.547 0-.313-.188-.524-.618-.524h-1.046l.476-2.304a1.06 1.06 0 0 0 .016-.164.51.51 0 0 0-.516-.516.54.54 0 0 0-.539.43l-.523 2.554H7.617l.477-2.304c.008-.04.015-.118.015-.164a.512.512 0 0 0-.523-.516.539.539 0 0 0-.531.43L6.53 5.484H5.414c-.43 0-.617.22-.617.532 0 .312.187.539.617.539h.906l-.515 2.523H4.609c-.421 0-.609.219-.609.531 0 .313.188.547.61.547h.976l-.516 2.492c-.008.04-.015.125-.015.18 0 .305.21.508.5.508.265 0 .492-.172.554-.477l.555-2.703h2.242l-.515 2.492zm-1-6.109h2.266l-.515 2.563H6.859l.532-2.563z"></path>
                    </svg></a></li>
                <li class="list-inline-item me-3"><a href="#!">
                    <svg class="bi bi-instagram" xmlns="http://www.w3.org/2000/svg" width="32" height="32" fill="#7D7987" viewBox="0 0 16 16">
                      <path d="M8 0C5.829 0 5.556.01 4.703.048 3.85.088 3.269.222 2.76.42a3.917 3.917 0 0 0-1.417.923A3.927 3.927 0 0 0 .42 2.76C.222 3.268.087 3.85.048 4.7.01 5.555 0 5.827 0 8.001c0 2.172.01 2.444.048 3.297.04.852.174 1.433.372 1.942.205.526.478.972.923 1.417.444.445.89.719 1.416.923.51.198 1.09.333 1.942.372C5.555 15.99 5.827 16 8 16s2.444-.01 3.298-.048c.851-.04 1.434-.174 1.943-.372a3.916 3.916 0 0 0 1.416-.923c.445-.445.718-.891.923-1.417.197-.509.332-1.09.372-1.942C15.99 10.445 16 10.173 16 8s-.01-2.445-.048-3.299c-.04-.851-.175-1.433-.372-1.941a3.926 3.926 0 0 0-.923-1.417A3.911 3.911 0 0 0 13.24.42c-.51-.198-1.092-.333-1.943-.372C10.443.01 10.172 0 7.998 0h.003zm-.717 1.442h.718c2.136 0 2.389.007 3.232.046.78.035 1.204.166 1.486.275.373.145.64.319.92.599.28.28.453.546.598.92.11.281.24.705.275 1.485.039.843.047 1.096.047 3.231s-.008 2.389-.047 3.232c-.035.78-.166 1.203-.275 1.485a2.47 2.47 0 0 1-.599.919c-.28.28-.546.453-.92.598-.28.11-.704.24-1.485.276-.843.038-1.096.047-3.232.047s-2.39-.009-3.233-.047c-.78-.036-1.203-.166-1.485-.276a2.478 2.478 0 0 1-.92-.598 2.48 2.48 0 0 1-.6-.92c-.109-.281-.24-.705-.275-1.485-.038-.843-.046-1.096-.046-3.233 0-2.136.008-2.388.046-3.231.036-.78.166-1.204.276-1.486.145-.373.319-.64.599-.92.28-.28.546-.453.92-.598.282-.11.705-.24 1.485-.276.738-.034 1.024-.044 2.515-.045v.002zm4.988 1.328a.96.96 0 1 0 0 1.92.96.96 0 0 0 0-1.92zm-4.27 1.122a4.109 4.109 0 1 0 0 8.217 4.109 4.109 0 0 0 0-8.217zm0 1.441a2.667 2.667 0 1 1 0 5.334 2.667 2.667 0 0 1 0-5.334z"> </path>
                    </svg></a></li>
              </ul>
            </div>
          </div>
          <div class="row flex-center">
            <div class="col-auto">
              <p class="mb-0 fs--1 text-700">&copy; Tüm Hakları Saklıdır</p>
            </div>
          </div>
        </div>
      </section>
    </main>
</template>

<script>
export default {

  data() {
    return {

    }
  },

  methods: {
    goLoginPage() {
      this.$router.push("/authentication/login");
    },

    goRegisterPage() {
      this.$router.push("/authentication/register");
    }
  }
}
</script>

<style>
@import "../../assets/css/theme.css";

.firstSection {
  background-image:url("../../assets/images/illustrations/hero-bg.png");
  background-position:bottom;
  background-size:cover;
}
</style>