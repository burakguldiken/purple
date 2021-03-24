<template>
  <div>
    <br /><br />
    <div class="container-fluid">
      <div class="user-profile">
        <div class="row">
          <div class="col-sm-12">
            <div class="card hovercard text-center">
              <div class="cardheader"></div>
              <div class="user-image">
                <div class="avatar">
                  <img alt="" src="../../assets/images/user/7.jpg" />
                </div>
                <div class="icon-wrapper">
                  <i class="icofont icofont-pencil-alt-5"></i>
                </div>
                <ul class="share-icons">
                  <li>
                    <a class="social-icon bg-primary" href="#"
                      ><i class="fa fa-smile-o"></i
                    ></a>
                  </li>
                  <li>
                    <a class="social-icon bg-secondary" href="#"
                      ><i class="fa fa-wechat"></i
                    ></a>
                  </li>
                  <li>
                    <a class="social-icon bg-warning" href="#"
                      ><i class="fa fa-share-alt"></i
                    ></a>
                  </li>
                </ul>
              </div>
              <div class="info m-t-20">
                <div class="row">
                  <div class="col-sm-6 col-lg-4 order-sm-1 order-xl-0">
                    <div class="row">
                      <div class="col-md-6">
                        <div class="ttl-info text-left">
                          <h5><i class="fa fa-envelope mr-2"></i>Email</h5>
                          <span>Marekjecno@yahoo.com</span>
                        </div>
                      </div>
                      <div class="col-md-6">
                        <div class="ttl-info text-left">
                          <h5><i class="fa fa-calendar mr-2"></i>BOD</h5>
                          <span>02 January 1988</span>
                        </div>
                      </div>
                    </div>
                  </div>
                  <div class="col-sm-12 col-lg-4 order-sm-0 order-xl-1">
                    <div class="user-designation">
                      <div class="title">
                        <a target="_blank" href="">Mark jecno</a>
                      </div>
                      <div class="desc mt-2">designer</div>
                    </div>
                  </div>
                  <div class="col-sm-6 col-lg-4 order-sm-2 order-xl-2">
                    <div class="row">
                      <div class="col-md-6">
                        <div class="ttl-info text-left">
                          <h5><i class="fa fa-phone mr-2"></i>Contact Us</h5>
                          <span>India +91 123-456-7890</span>
                        </div>
                      </div>
                      <div class="col-md-6">
                        <div class="ttl-info text-left">
                          <h5>
                            <i class="fa fa-location-arrow mr-2"></i>Location
                          </h5>
                          <span>B69 Near Schoool Demo Home</span>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div class="col-sm-12">
            <div class="card">
              <div class="profile-img-style">
                <div class="row">
                  <div class="col-sm-8">
                    <div class="media">
                      <img
                        class="img-thumbnail rounded-circle mr-3"
                        src="../../assets/images/user/7.jpg"
                        alt="Generic placeholder image"
                      />
                      <div class="media-body align-self-center">
                        <h5 class="mt-0 user-name">About</h5>
                      </div>
                    </div>
                  </div>
                  <div class="col-sm-4 align-self-center">
                    <div class="float-sm-right">
                      <small>10 Hours ago</small>
                    </div>
                  </div>
                </div>
                <hr />
                <p>
                  Contrary to popular belief, Lorem Ipsum is not simply random
                  text. It has roots in a piece of classical Latin literature
                  from 45 BC, making it over 2000 years old. Richard McClintock,
                  a Latin professor at Hampden-Sydney College in Virginia,
                  looked up one of the more obscure Latin words, consectetur,
                  from a Lorem Ipsum passage, and going through the cites of the
                  word in classical literature, discovered the undoubtable
                  source .Contrary to popular belief, Lorem Ipsum is not simply
                  random text. It has roots in a piece of classical Latin
                  literature from 45 BC, making it over 2000 years old. Richard
                  McClintock, a Latin professor at Hampden-Sydney College in
                  Virginia, looked up one of the more obscure Latin words,
                  consectetur, from a Lorem Ipsum passage, and going through the
                  cites of the word in classical literature, discovered the
                  undoubtable source
                </p>
              </div>
            </div>
          </div>
          <div>
            <div class="row m-l-5 m-r-1">
              <div class="col-sm-12">
                <div class="card">
                  <div class="profile-img-style">
                    <div class="row">
                      <div class="col-sm-8">
                        <div class="media">
                          <img
                            class="img-thumbnail rounded-circle mr-3"
                            src="../../assets/images/user/7.jpg"
                            alt="Generic placeholder image"
                          />
                          <div class="media-body align-self-center">
                            <h5 class="mt-0 user-name">Portfolio</h5>
                          </div>
                        </div>
                      </div>
                      <div class="col-sm-4 align-self-center">
                        <div class="float-sm-right">
                          <small>10 Hours ago</small>
                        </div>
                      </div>
                    </div>
                  </div>
                  <div
                    class="my-gallery card-body row gallery-with-description"
                    itemscope=""
                  >
                    <VueGallery
                      :images="bigimages"
                      :index="index"
                      @close="index = null"
                    ></VueGallery>
                    <figure
                      class="col-xl-3 col-sm-6 m-0"
                      v-for="(figure, imageIndex) in figureslist"
                      :key="imageIndex"
                    >
                      <a @click="index = imageIndex">
                        <img
                          :src="require('../../assets/images/' + figure.image)"
                          alt="Image description"
                          class="img-fluid"
                        />
                        <div class="caption">
                          <h4 v-text="figure.title"></h4>
                          <p v-text="figure.descr"></p>
                        </div>
                      </a>
                    </figure>
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