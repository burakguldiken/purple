<template>
  <div>
    <br><br>
    <div class="container-fluid">
      <div class="row">
        <div class="col-xl-9 xl-60">
          <div class="card">
            <div class="job-search">
              <div class="card-body">
                <div class="media">
                  <img
                    class="img-40 img-fluid m-r-20"
                    :src="getImgUrl(jobs.image)"
                    alt=""
                  />
                  <div class="media-body">
                    <h6 class="f-w-600">
                      <router-link
                        :to="{ name: 'JobDetails', params: { id: jobs.id } }"
                        >{{ jobs.title }}</router-link
                      >
                      <span class="pull-right">
                        <router-link
                          :to="{ name: 'JobApply', params: { id: jobs.id } }"
                          class="btn btn-primary btn-sm"
                          >Apply for this job</router-link
                        ></span
                      >
                    </h6>
                    <p>
                      {{ jobs.company }}
                      <span>{{ jobs.city }}, {{ jobs.country }} </span
                      ><span v-html="stars(jobs.stars)"></span>
                    </p>
                  </div>
                </div>
                <div class="job-description">
                  <h6>Job Description</h6>
                  <p v-html="jobs.description"></p>
                </div>
                <div class="job-description">
                  <h6>Responsibilities</h6>
                  <ul>
                    <li
                      v-for="(r, index) in jobs.resp"
                      :key="index"
                      v-text="r.title"
                    ></li>
                  </ul>
                </div>
                <div class="job-description">
                  <h6>Requirements</h6>
                  <ul>
                    <li
                      v-for="(rq, index) in jobs.reqs"
                      :key="index"
                      v-text="rq.title"
                    ></li>
                  </ul>
                </div>
                <div class="job-description">
                  <h6>Required Skills</h6>
                  <ul>
                    <li>
                      Proficient understanding of web markup, including HTML5,
                      CSS3
                    </li>
                    <li
                      v-for="(ski, index) in jobs.skills"
                      :key="index"
                      v-text="ski.title"
                    ></li>
                  </ul>
                </div>
                <div slot="with-padding"></div>
                <div class="job-description">
                  <button class="btn btn-primary mr-1 btn-sm" type="button">
                    <span><i class="fa fa-check"></i></span> Save this job
                  </button>
                  <button class="btn btn-primary btn-sm" type="button">
                    <span><i class="fa fa-share-alt"></i></span> Share
                  </button>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div class="col-xl-3 risk-col xl-100 box-col-12">
          <div class="card total-users">
            <div class="card-header card-no-border">
            </div>
            <div class="card-body pt-0">
              <div class="apex-chart-container goal-status text-center row">
                <div class="rate-card col-xl-12">
                  <div class="goal-chart">
                    <div id="riskfactorchart">
                      <apexchart
                        height="350"
                        type="radialBar"
                        :options="apexRiskchart.options"
                        :series="apexRiskchart.series"
                      ></apexchart>
                    </div>
                  </div>
                  <div class="goal-end-point">
                    <ul>
                      <li class="mt-0 pt-0">
                        <h6 class="font-primary">Publish Date</h6>
                        <h6 class="f-w-400">24 March 2021</h6>
                      </li>
                      <li>
                        <h6 class="mb-2 f-w-400">Publisher</h6>
                        <h5 class="mb-0">Cenin İnşaat</h5>
                      </li>
                    </ul>
                  </div>
                </div>
                <ul class="col-xl-12">
                  <li>
                    <div class="goal-detail">
                      <h6>
                        <span class="font-primary">Views :</span>235
                      </h6>
                      <div class="progress sm-progress-bar progress-animate">
                        <div
                          class="progress-gradient-primary"
                          role="progressbar"
                          style="width: 100%"
                          aria-valuenow="100"
                          aria-valuemin="0"
                          aria-valuemax="100"
                        ></div>
                      </div>
                    </div>
                    <div class="goal-detail mb-0">
                      <h6>
                        <span class="font-primary">Application:</span>50
                      </h6>
                      <div class="progress sm-progress-bar progress-animate">
                        <div
                          class="progress-gradient-primary"
                          role="progressbar"
                          style="width: 100%"
                          aria-valuenow="100"
                          aria-valuemin="0"
                          aria-valuemax="100"
                        ></div>
                      </div>
                    </div>
                  </li>
                </ul>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <!-- Container-fluid Ends-->
  </div>
</template>

<script>
var primary = localStorage.getItem("primary_color") || "#7366ff";
var secondary = localStorage.getItem("secondary_color") || "#f73164";
import { mapState } from "vuex";
import router from "@/router";
export default {
  data() {
      return {
      apexRiskchart: {
        options: {
          plotOptions: {
            radialBar: {
              hollow: {
                margin: 5,
                size: "60%",
                image: require("../../assets/images/dashboard-2/radial-image.png"),
                imageWidth: 140,
                imageHeight: 140,
                imageClipped: false,
              },
            },
          },
          labels: ["Frontend Developer"],
          colors: [primary],
          stroke: {
            dashArray: 15,
            strokecolor: ["#ffffff"],
          },
          fill: {
            type: "gradient",
            gradient: {
              shade: "light",
              shadeIntensity: 0.15,
              inverseColors: false,
              opacityFrom: 1,
              opacityTo: 1,
              stops: [0, 100],
              gradientToColors: ["#a927f9"],
              type: "horizontal",
            },
          },
        },
        series: [100],
      },
      }
  },
  props: ["id"],
  computed: {
    ...mapState({
      jobs: (state) =>
        state.jobs.jobs.find((job) => {
          if (router.currentRoute.params.id == job.id) return job;
        }),
      jobslist: (state) => state.jobs.jobs,
    }),
  },
  created() {
    // console.log(this.id);
  },
  methods: {
    getImgUrl(filename) {
      var images = require.context(
        "../../assets/images/job-search/",
        false,
        /\.jpg$/
      );
      return images("./" + filename);
    },
    stars(count) {
      var stars = "";

      for (var i = 0; i < 5; i++) {
        if (count > i) {
          stars = stars + '<i class="fa fa-star font-warning"></i>';
        } else {
          stars = stars + '<i class="fa fa-star font-warning-o"></i>';
        }
      }

      return stars;
    },
  },
};
</script>
