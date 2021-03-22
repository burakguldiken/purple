<template>
  <div class="container-fluid">
    <div class="row">
      <div class="col-xl-7">
        <img
          class="bg-img-cover bg-center"
          src="../../assets/images/login/1.jpg"
          alt="looginpage"
        />
      </div>
      <div class="col-xl-5 p-0">
        <div class="login-card">
          <div>
            <div>
              <a class="logo text-center">
                <img
                  width="40%"
                  class="img-fluid for-light"
                  src="../../assets/images/logo/purplelogo.png"
                  alt="looginpage"
                />
                <img
                  width="40%"
                  class="img-fluid for-dark"
                  src="../../assets/images/logo/purplelogo.png"
                  alt="looginpage"
                />
              </a>
            </div>
            <div class="login-main login-form-card">
              <form class="theme-form">
                <h4>Sign in to account</h4>
                <p>Enter your email & password to login</p>
                <div class="form-group">
                  <label class="col-form-label">Email Address</label>
                  <input
                    v-model="user.email"
                    class="form-control"
                    type="email"
                    required=""
                    placeholder="Test@gmail.com"
                  />
                </div>
                <div class="form-group">
                  <label class="col-form-label">Password</label>
                  <input
                    v-model="user.password"
                    class="form-control"
                    :type="passwordType"
                    name="login[password]"
                    required=""
                    placeholder="*********"
                  />
                  <div class="show-hide"><span @click="changePassVisibility" class="show"> </span></div>
                </div>
                <div class="form-group mb-0">
                  <div class="checkbox p-0">
                    <input id="checkbox1" type="checkbox" />
                    <label class="text-muted" for="checkbox1"
                      >Remember password</label
                    >
                  </div>
                  <button class="btn btn-primary btn-block" type="button" @click="login">
                    Sign in
                  </button>
                </div>
                <h6 class="text-muted mt-4 or">Or Sign in with</h6>
                <div class="social mt-4">
                  <div class="btn-showcase">
                    <a class="btn btn-light">
                      <i class="fa fa-google txt-linkedin"></i>
                      Google
                    </a>
                    <a class="btn btn-light">
                      <feather type="twitter" class="txt-twitter"></feather
                      >twitter</a
                    >
                    <a class="btn btn-light">
                      <feather type="facebook" class="txt-fb"></feather
                      >facebook</a
                    >
                  </div>
                </div>
                <p class="mt-4 mb-0">
                  Don't have account?<router-link
                    class="ml-2"
                    tag="a"
                    to="/authentication/register"
                  >
                    Create Account
                  </router-link>
                </p>
              </form>
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
                password:"******",
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