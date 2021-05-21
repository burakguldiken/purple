<template>
    <div class="main-banner wow fadeIn" id="top" data-wow-duration="1s" data-wow-delay="0.5s">
    <div class="container">
      <div class="row m-b-5">
        <div class="col-lg-12">
          <div class="row">
            <div class="col-lg-6">
            </div>
            <div class="col-lg-6 align-self-center">
              <div class="text-right left-content header-text wow fadeInLeft" data-wow-duration="1s" data-wow-delay="1s">
                <h2>Dijital Fikirler ve <em>SEO Pazarlaması</em></h2>
              </div>
            </div>
          </div>
          <div class="row">
            <div class="col-lg-6">
              <div class="right-image wow fadeInRight" data-wow-duration="1s" data-wow-delay="0.5s">
                <img width="100%" src="../../assets/images/banner-right-image.png" alt="team meeting">
              </div>
            </div>
            <div class="col-lg-6 align-self-center">
              <div class="login-card b-r-10">
                <div>
                  <div class="login-main login-form-card shadow shadow-showcase">
                    <form class="theme-form">
                      <h4>Şimdi Giriş Yapın</h4>
                      <p>Email Adresinizi ve Şifrenizi Girin</p>
                      <div class="form-group">
                        <label class="col-form-label">Email</label>
                        <input
                          v-model="user.email"
                          class="form-control"
                          type="email"
                          required=""
                          placeholder="Test@gmail.com"
                        />
                      </div>
                      <div class="form-group">
                        <label class="col-form-label">Şifre</label>
                        <input
                          v-model="user.password"
                          class="form-control"
                          :type="passwordType"
                          name="login[password]"
                          required=""
                          placeholder="*********"
                        />
                        <div class="show-hide"><span @click="changePassVisibility" class="show txt-dark"><i class="icofont icofont-eye-alt f-16"></i></span></div>
                      </div>
                      <div class="form-group mb-0">
                        <div class="checkbox p-0">
                          <input id="checkbox1" type="checkbox" />
                          <label class="text-muted m-l-5" for="checkbox1">
                            Beni Hatırla
                          </label>
                        </div>
                        <button class="btn btn-dark btn-block" type="button" @click="login">
                          Giriş Yap
                        </button>
                      </div>
                      <h6 class="text-muted mt-4 or">Sosyal Medya İle</h6>
                      <div class="social mt-4">
                        <div class="btn-showcase">
                          <a class="btn btn-light"><i class="fa fa-google txt-linkedin"></i>Google</a>
                          <a class="btn btn-light"><feather type="twitter" class="txt-twitter"></feather>twitter</a>
                          <a class="btn btn-light"><feather type="github" class="txt-github"></feather>Github</a>
                        </div>
                      </div>
                      <p class="mt-4 mb-0">
                        <span>Henüz Bir Hesabın Yok Mu ?</span>
                        <router-link class="ml-2" tag="a" to="/authentication/register">
                          <span class="txt-secondary">Hesap Oluştur</span>
                        </router-link>
                      </p>
                    </form>
                  </div>
                </div>
              </div>
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
            user: {
                password:"12345",
                email:"Test@gmail.com"
            },
            passwordType:'password'
        }
    },

    methods: {
        changePassVisibility() {
            this.passwordType = this.passwordType === 'password' ? 'text' : 'password';
        },

        login() {
            this.$router.push("/dashboard/purple");
        }
    },
}
</script>

<style>
@import "../../assets/css/fontawesome.css";
@import "../../assets/css/templatemo-space-dynamictwo.css";
@import "../../assets/css/animated.css";
@import "../../assets/css/owl.css";
</style>