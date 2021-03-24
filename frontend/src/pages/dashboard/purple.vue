<template>
  <div>
    <br><br>
    <!-- <Breadcrumbs main="Dashboard" title="Purple" /> -->
    <!-- Container-fluid starts-->
    <div class="container-fluid">
      <div class="row second-chart-list third-news-update">
        <div class="col-xl-4 col-lg-12 xl-50 morning-sec box-col-12">
          <px-card class="profile-greeting">
            <div slot="with-padding">
              <div class="media">
                <div class="badge-groups w-100">
                  <div class="badge f-12">
                    <feather type="clock" class="mr-1"></feather>
                    <span id="txt">{{time}}</span>
                  </div>
                  <div class="badge f-12">
                    <i class="fa fa-spin fa-cog f-14"></i>
                  </div>
                </div>
              </div>
              <div class="greeting-user text-center">
                <div class="profile-vector">
                  <img class="img-fluid" src="../../assets/images/dashboard/welcome.png" alt />
                </div>
                <h4 class="f-w-600">
                  <span id="greeting">Hello Burak</span>
                  <span class="right-circle ml-1">
                    <i class="fa fa-check-circle f-14 middle"></i>
                  </span>
                </h4>
                <p>
                  <span>You can create new job postings or apply to existing postings</span>
                </p>
                <div class="whatsnew-btn">
                  <a class="btn btn-primary">View listings !</a>
                </div>
                <div class="left-icon">
                  <i class="fa fa-bell"></i>
                </div>
              </div>
            </div>
          </px-card>
        </div>
        <div class="col-xl-8 xl-100 dashboard-sec box-col-12">
          <px-card class="earning-card">
              <div class="row m-0">
                <div class="col-xl-3 earning-content p-0">
                  <div class="row m-0 chart-left">
                    <div class="col-xl-12 p-0 left_side_earning">
                      <h5>Purple</h5>
                      <p class="font-roboto">Freeworker template</p>
                    </div>
                    <div class="col-xl-12 p-0 left_side_earning">
                      <h5>178</h5>
                      <p class="font-roboto">Total number of postings</p>
                    </div>
                    <div class="col-xl-12 p-0 left_side_earning">
                      <h5>10.346</h5>
                      <p class="font-roboto">Total posting view</p>
                    </div>
                    <div class="col-xl-12 p-0 left_side_earning">
                      <h5><feather type="arrow-up" class="font-success"></feather>14%</h5>
                      <p class="font-roboto">This month ad</p>
                    </div>
                    <div class="col-xl-12 p-0 left-btn">
                      <a class="btn btn-gradient">Go To Profile</a>
                    </div>
                  </div>
                </div>
                <div class="col-xl-9 p-0">
                  <div class="chart-right">
                    <div class="row m-0 p-tb">
                      <div class="col-xl-8 col-md-8 col-sm-8 col-12 p-0">
                        <div class="inner-top-left">
                          <ul class="d-flex list-unstyled">
                            <li class="active">Daily</li>
                            <li>Weekly</li>
                            <li>Monthly</li>
                            <li>Yearly</li>
                          </ul>
                        </div>
                      </div>
                      <div class="col-xl-4 col-md-4 col-sm-4 col-12 p-0 justify-content-end">
                        <div class="inner-top-right">
                          <ul class="d-flex list-unstyled justify-content-end">
                            <li>New Ad</li>
                            <li>View Ad</li>
                          </ul>
                        </div>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-xl-12">
                        <div class="card-body p-0">
                          <div class="current-sale-container">
                            <div id="chart-currently">
                              <apexchart
                                height="240"
                                type="area"
                                :options="apexDashboard.options"
                                :series="apexDashboard.series"
                              ></apexchart>
                            </div>
                          </div>
                        </div>
                      </div>
                    </div>
                  </div>
                  <div class="row border-top m-0">
                    <div class="col-xl-4 pl-0 col-md-6 col-sm-6">
                      <div class="media p-0">
                        <div class="media-left">
                          <i class="icofont icofont-users"></i>
                        </div>
                        <div class="media-body">
                          <h6>Total Users</h6>
                          <p>300</p>
                        </div>
                      </div>
                    </div>
                    <div class="col-xl-4 col-md-6 col-sm-6">
                      <div class="media p-0">
                        <div class="media-left bg-secondary">
                          <i class="icofont icofont-heart-alt"></i>
                        </div>
                        <div class="media-body">
                          <h6>Users This Month</h6>
                          <p>30</p>
                        </div>
                      </div>
                    </div>
                    <div class="col-xl-4 col-md-12 pr-0">
                      <div class="media p-0">
                        <div class="media-left">
                          <i class="icofont icofont-exchange"></i>
                        </div>
                        <div class="media-body">
                          <h6>Users This Year</h6>
                          <p>200</p>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
          </px-card>
        </div>
        <div class="col-xl-12 xl-100 chart_data_left box-col-12">
          <px-card>
            <div class="row m-0 chart-main">
                <div class="col-xl-3 col-md-6 col-sm-6 p-0 box-col-6">
                  <div class="media align-items-center">
                    <div class="hospital-small-chart">
                      <div class="small-bar">
                        <div class="small-chart2 flot-chart-container">
                          <chartist
                            type="Bar"
                            :data="smallchart1.chartData_1"
                            :options="smallchart1.chartOptions"
                            :event-handlers="smallchart1.eventHandlers"
                          ></chartist>
                        </div>
                      </div>
                    </div>
                    <div class="media-body m-t-10">
                      <div class="right-chart-content">
                        <h4>5</h4>
                        <span>Your Total Posting</span>
                      </div>
                    </div>
                  </div>
                </div>
                <div class="col-xl-3 col-md-6 col-sm-6 p-0 box-col-6">
                  <div class="media align-items-center">
                    <div class="hospital-small-chart">
                      <div class="small-bar">
                        <div class="small-chart1 flot-chart-container">
                          <chartist
                            type="Bar"
                            :data="smallchart2.chartData_1"
                            :options="smallchart2.chartOptions"
                            :event-handlers="smallchart2.eventHandlers"
                          ></chartist>
                        </div>
                      </div>
                    </div>
                    <div class="media-body m-t-10">
                      <div class="right-chart-content">
                        <h4>20</h4>
                        <span>Your application</span>
                      </div>
                    </div>
                  </div>
                </div>
                <div class="col-xl-3 col-md-6 col-sm-6 p-0 box-col-6">
                  <div class="media align-items-center">
                    <div class="hospital-small-chart">
                      <div class="small-bar">
                        <div class="small-chart2 flot-chart-container">
                          <chartist
                            type="Bar"
                            :data="smallchart3.chartData_1"
                            :options="smallchart3.chartOptions"
                            :event-handlers="smallchart3.eventHandlers"
                          ></chartist>
                        </div>
                      </div>
                    </div>
                    <div class="media-body m-t-10">
                      <div class="right-chart-content">
                        <h4>139</h4>
                        <span>Your number of ad views</span>
                      </div>
                    </div>
                  </div>
                </div>
                <div class="col-xl-3 col-md-6 col-sm-6 p-0 box-col-6">
                  <div class="media border-none align-items-center">
                    <div class="hospital-small-chart">
                      <div class="small-bar">
                        <div class="small-chart3 flot-chart-container">
                          <chartist
                            type="Bar"
                            :data="smallchart4.chartData_1"
                            :options="smallchart4.chartOptions"
                            :event-handlers="smallchart4.eventHandlers"
                          ></chartist>
                        </div>
                      </div>
                    </div>
                    <div class="media-body m-t-10">
                      <div class="right-chart-content">
                        <h4>14 min</h4>
                        <span>Average time spent here</span>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
          </px-card>
        </div>
        <div class="col-xl-4 xl-50 news box-col-6">
          <div class="card">
            <div class="card-header card-no-border">
              <h5>Latest Listings</h5>
              <div class="card-header-right">
                <ul class="list-unstyled card-option">
                  <li>
                    <i class="fa fa-spin fa-cog"></i>
                  </li>
                  <li>
                    <i class="view-html fa fa-code"></i>
                  </li>
                  <li>
                    <i class="icofont icofont-maximize full-card"></i>
                  </li>
                  <li>
                    <i class="icofont icofont-minus minimize-card"></i>
                  </li>
                  <li>
                    <i class="icofont icofont-refresh reload-card"></i>
                  </li>
                  <li>
                    <i class="icofont icofont-error close-card"></i>
                  </li>
                </ul>
              </div>
            </div>
            <div class="card-body new-update pt-0">
              <div class="activity-timeline">
                <div class="media">
                  <div class="activity-line"></div>
                  <div class="activity-dot-secondary"></div>
                  <div class="media-body">
                    <span>
                      Frontend Developer
                      <i
                        class="fa fa-circle circle-dot-secondary pull-right"
                      ></i>  
                    </span>
                    <p class="font-roboto">At least 1 year of experience with Vue.js, React or Angular...</p>
                  </div>
                </div>
                <div class="media">
                  <div class="activity-dot-primary"></div>
                  <div class="media-body">
                    <span>
                      Backend Developer
                      <i
                        class="fa fa-circle circle-dot-secondary pull-right"
                      ></i>  
                    </span>
                    <p class="font-roboto">At least 1 year of experience with .Net Core...</p>
                  </div>
                </div>
                <div class="media">
                  <div class="activity-dot-secondary"></div>
                  <div class="media-body">
                    <span>
                      Mobile Developer
                      <i
                        class="fa fa-circle circle-dot-secondary pull-right"
                      ></i>
                    </span>
                    <p class="font-roboto">At least 3 year of experience Swift...</p>
                  </div>
                </div>
                <div class="media">
                  <div class="activity-dot-primary"></div>
                  <div class="media-body">
                    <span>
                      Sales Marketing Specialist
                      <i
                        class="fa fa-circle circle-dot-secondary pull-right"
                      ></i>  
                    </span>
                    <p class="font-roboto">5 years of experience in sales and marketing...</p>
                  </div>
                </div>
                <div slot="footer" class="m-t-35">
                  <div class="bottom-btn">
                    <a href="#">More...</a>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div class="col-xl-8 xl-50 appointment-sec box-col-6">
          <div class="card">
                <div class="card-body">
                  <div class="best-seller-table responsive-tbl">
                    <div class="item">
                      <div class="table-responsive product-list">
                        <table class="table table-bordernone">
                          <thead>
                            <tr>
                              <th class="f-22">Best Freeworkers</th>
                              <th>Join Date</th>
                              <th>Email</th>
                              <th>Country</th>
                              <th>Total Ad</th>
                              <th class="text-right">Average Time/Week</th>
                            </tr>
                          </thead>
                          <tbody>
                            <tr>
                              <td>
                                <div class="d-inline-block align-middle">
                                  <img
                                    class="img-40 m-r-15 rounded-circle align-top"
                                    src="../../assets/images/avtar/17.jpg"
                                    alt
                                  />
                                  <div class="status-circle bg-primary"></div>
                                  <div class="d-inline-block">
                                    <span>John keter</span>
                                    <p class="font-roboto">2019</p>
                                  </div>
                                </div>
                              </td>
                              <td>06 August</td>
                              <td>john.keter@gmail.com.tr</td>
                              <td>
                                <i class="flag-icon flag-icon-tr"></i>
                              </td>
                              <td>
                                <span class="label">18</span>
                              </td>
                              <td class="text-right">
                                <i class="fa fa-check-circle"></i>1 hour 30 min
                              </td>
                            </tr>
                            <tr>
                              <td>
                                <div class="d-inline-block align-middle">
                                  <img
                                    class="img-40 m-r-15 rounded-circle align-top"
                                    src="../../assets/images/avtar/18.jpg"
                                    alt
                                  />
                                  <div class="status-circle bg-primary"></div>
                                  <div class="d-inline-block">
                                    <span>Herry Venter</span>
                                    <p class="font-roboto">2020</p>
                                  </div>
                                </div>
                              </td>
                              <td>21 March</td>
                              <td>herry.venter@gmail.com.tr</td>
                              <td>
                                <i class="flag-icon flag-icon-ru"></i>
                              </td>
                              <td>
                                <span class="label">17</span>
                              </td>
                              <td class="text-right">
                                <i class="fa fa-check-circle"></i>1 hour 22 min
                              </td>
                            </tr>
                            <tr>
                              <td>
                                <div class="d-inline-block align-middle">
                                  <img
                                    class="img-40 m-r-15 rounded-circle align-top"
                                    src="../../assets/images/avtar/19.jpg"
                                    alt
                                  />
                                  <div class="status-circle bg-primary"></div>
                                  <div class="d-inline-block">
                                    <span>loain deo</span>
                                    <p class="font-roboto">2020</p>
                                  </div>
                                </div>
                              </td>
                              <td>09 March</td>
                              <td>loain.deo@gmail.com.tr</td>
                              <td>
                                <i class="flag-icon flag-icon-za"></i>
                              </td>
                              <td>
                                <span class="label">17</span>
                              </td>
                              <td class="text-right">
                                <i class="fa fa-check-circle"></i>1 hour 10 min
                              </td>
                            </tr>
                            <tr>
                              <td>
                                <div class="d-inline-block align-middle">
                                  <img
                                    class="img-40 m-r-15 rounded-circle align-top"
                                    src="../../assets/images/avtar/17.jpg"
                                    alt
                                  />
                                  <div class="status-circle bg-primary"></div>
                                  <div class="d-inline-block">
                                    <span>Horen Hors</span>
                                    <p class="font-roboto">2020</p>
                                  </div>
                                </div>
                              </td>
                              <td>14 February</td>
                              <td>horen.hors@gmail.com.tr</td>
                              <td>
                                <i class="flag-icon flag-icon-at"></i>
                              </td>
                              <td>
                                <span class="label">16</span>
                              </td>
                              <td class="text-right">
                                <i class="fa fa-check-circle"></i>1 hour 0 min
                              </td>
                            </tr>
                            <tr>
                              <td>
                                <div class="d-inline-block align-middle">
                                  <img
                                    class="img-40 m-r-15 rounded-circle align-top"
                                    src="../../assets/images/avtar/18.jpg"
                                    alt
                                  />
                                  <div class="status-circle bg-primary"></div>
                                  <div class="d-inline-block">
                                    <span>fenter Jessy</span>
                                    <p class="font-roboto">2021</p>
                                  </div>
                                </div>
                              </td>
                              <td>12 January</td>
                              <td>fenter.jessy@gmail.com.tr</td>
                              <td>
                                <i class="flag-icon flag-icon-br"></i>
                              </td>
                              <td>
                                <span class="label">14</span>
                              </td>
                              <td class="text-right">
                                <i class="fa fa-check-circle"></i>57 min
                              </td>
                            </tr>
                          </tbody>
                        </table>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
        </div>
        <div class="col-sm-12 col-lg-6 col-xl-4 xl-50 col-md-12 box-col-6">
          <div class="card height-equal">
            <div class="calender-widget">
              <div class="cal-img center-img m-b-25"></div>
              <div class="cal-date">
                <h5>Purple<br>Freeworkers</h5>
              </div>
              <div class="cal-desc text-center card-body">
                <h6 class="f-w-600">You Can Contact Us</h6>
                <p class="text-muted mt-3 mb-0">You can tell us about the problems, complaints or errors you encounter. You can also write to us for your suggestions and comments.<br>Your mails sent to us are answered within 7 to 1 business days from the day they are sent.</p>
              </div>
            </div>
          </div>
        </div>
        <div class="col-sm-12 col-lg-6 col-xl-8 xl-50 col-md-12 box-col-6">
          <div class="card height-equal">
            <div class="card-header">
              <h5>Contact Us</h5>
            </div>
            <div class="contact-form card-body">
              <form class="theme-form">
                <div class="form-icon"><i class="icofont icofont-envelope-open"></i></div>
                <div class="form-group">
                  <label for="exampleInputName">Title</label>
                  <input class="form-control" id="exampleInputName" type="text" placeholder="Test Title">
                </div>
                <div class="form-group">
                  <label class="col-form-label" for="exampleInputEmail1">Email</label>
                  <input class="form-control" id="exampleInputEmail1" type="email" placeholder="purplesupport@gmail.com">
                </div>
                <div class="form-group">
                  <label class="col-form-label" for="exampleInputEmail1">Message</label>
                  <textarea class="form-control textarea" rows="3" cols="50" placeholder="Your Message"></textarea>
                </div>
                <div class="text-sm-right">
                  <button class="btn btn-primary btn-xs">Send</button>
                </div>
              </form>

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
var Knob = require("knob");
var ordervalue = Knob({
  value: 35,
  angleOffset: 90,
  className: "review",
  thickness: 0.2,
  width: 65,
  height: 65,
  fgColor: primary,
});
var productvalue = Knob({
  value: 60,
  angleOffset: 90,
  className: "review",
  thickness: 0.2,
  width: 65,
  height: 65,
  fgColor: primary,
});
import * as Chartist from "chartist";
export default {
  data() {
    return {
      interval:null,
      time:null,
      events: [
        {
            title  : 'event1',
            start  : '2010-01-01',
        },
        {
            title  : 'event2',
            start  : '2010-01-05',
            end    : '2010-01-07',
        },
        {
            title  : 'event3',
            start  : '2010-01-09T12:30:00',
            allDay : false,
        },
      ],
      smallchart1: {
        chartData_1: {
          labels: ["Q1", "Q2", "Q3", "Q4", "Q5", "Q6", "Q7"],
          series: [
            [400, 900, 800, 1000, 700, 1200, 300],
            [1000, 500, 600, 400, 700, 200, 1100],
          ],
        },
        chartOptions: {
          stackBars: true,
          axisX: {
            showGrid: false,
            showLabel: false,
            offset: 0,
          },
          axisY: {
            low: 0,
            showGrid: false,
            showLabel: false,
            offset: 0,
            labelInterpolationFnc: function (value) {
              return value / 1000 + "k";
            },
          },
        },
        eventHandlers: [
          {
            event: "draw",
            fn(data) {
              if (data.type === "bar") {
                data.element.attr({
                  style: "stroke-width: 3px",
                });
              }
            },
          },
        ],
      },
      smallchart2: {
        chartData_1: {
          labels: ["Q1", "Q2", "Q3", "Q4", "Q5", "Q6", "Q7"],
          series: [
            [400, 600, 900, 800, 1000, 1200, 500],
            [1000, 800, 500, 600, 400, 200, 900],
          ],
        },
        chartOptions: {
          stackBars: true,
          axisX: {
            showGrid: false,
            showLabel: false,
            offset: 0,
          },
          axisY: {
            low: 0,
            showGrid: false,
            showLabel: false,
            offset: 0,
            labelInterpolationFnc: function (value) {
              return value / 1000 + "k";
            },
          },
        },
        eventHandlers: [
          {
            event: "draw",
            fn(data) {
              if (data.type === "bar") {
                data.element.attr({
                  style: "stroke-width: 3px",
                });
              }
            },
          },
        ],
      },
      smallchart3: {
        chartData_1: {
          labels: ["Q1", "Q2", "Q3", "Q4", "Q5", "Q6", "Q7"],
          series: [
            [1100, 900, 600, 1000, 700, 1200, 300],
            [300, 500, 800, 400, 700, 200, 1100],
          ],
        },
        chartOptions: {
          stackBars: true,
          axisX: {
            showGrid: false,
            showLabel: false,
            offset: 0,
          },
          axisY: {
            low: 0,
            showGrid: false,
            showLabel: false,
            offset: 0,
            labelInterpolationFnc: function (value) {
              return value / 1000 + "k";
            },
          },
        },
        eventHandlers: [
          {
            event: "draw",
            fn(data) {
              if (data.type === "bar") {
                data.element.attr({
                  style: "stroke-width: 3px",
                });
              }
            },
          },
        ],
      },
      smallchart4: {
        chartData_1: {
          labels: ["Q1", "Q2", "Q3", "Q4", "Q5", "Q6", "Q7"],
          series: [
            [400, 600, 800, 1000, 700, 1100, 300],
            [1000, 500, 600, 300, 700, 200, 1100],
          ],
        },
        chartOptions: {
          stackBars: true,
          axisX: {
            showGrid: false,
            showLabel: false,
            offset: 0,
          },
          axisY: {
            low: 0,
            showGrid: false,
            showLabel: false,
            offset: 0,
            labelInterpolationFnc: function (value) {
              return value / 1000 + "k";
            },
          },
        },
        eventHandlers: [
          {
            event: "draw",
            fn(data) {
              if (data.type === "bar") {
                data.element.attr({
                  style: "stroke-width: 3px",
                });
              }
            },
          },
        ],
      },
      apexDashboard: {
        options: {
          chart: {
            width: 685,
            height: 240,
            type: "area",
            toolbar: {
              show: false,
            },
          },
          colors: [primary, secondary],
          dataLabels: {
            enabled: false,
          },
          stroke: {
            curve: "smooth",
          },
          xaxis: {
            type: "category",
            low: 0,
            offsetX: 0,
            offsetY: 0,
            show: false,
            categories: [
              "Jan",
              "Feb",
              "Mar",
              "Apr",
              "May",
              "Jun",
              "Jul",
              "Aug",
              "Sep",
              "Oct",
              "Nov",
              "Dec",
              "Jan",
            ],
            labels: {
              low: 0,
              offsetX: 0,
              show: false,
            },
            axisBorder: {
              low: 0,
              offsetX: 0,
              show: false,
            },
          },
          yaxis: {
            low: 0,
            offsetX: 0,
            offsetY: 0,
            show: false,
            labels: {
              low: 0,
              offsetX: 0,
              show: false,
            },
            axisBorder: {
              low: 0,
              offsetX: 0,
              show: false,
            },
          },
          markers: {
              strokeWidth: 3,
              colors: "#ffffff",
              strokeColors: [ primary , secondary ],
              hover: {
                  size: 6,
              }
          },
          fill: {
              type: 'gradient',
              gradient: {
                  shadeIntensity: 1,
                  opacityFrom: 0.7,
                  opacityTo: 0.5,
                  stops: [0, 80, 100]
              }
          },
          legend: {
        show: false,
    },
    tooltip: {
        x: {
            format: 'MM'
        },
    },
          grid: {
              show: false,
              padding: {
                  left: 0,
                  right: 0,
                  bottom: -15,
                  top: -40
              }
          },
        },
        series: [
          {
            name: "series1",
            data: [6, 20, 15, 40, 18, 20, 18, 23, 18, 35, 30, 55, 0],
          },
          {
            name: "series2",
            data: [2, 22, 35, 32, 40, 25, 50, 38, 42, 28, 20, 45, 0],
          },
        ],
      },
      apexMarketValue: {
        options: {
          chart: {
            width: 505,
            height: 380,
            type: "radar",
            toolbar: {
              show: false,
            },
          },
          colors: [primary],
          dataLabels: {
            enabled: false,
          },
          labels: [
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
          ],
          stroke: {
            width: 3,
            curve: "smooth",
          },
          plotOptions: {
            radar: {
              size: 140,
              polygons: {
                fill: {
                  colors: ["#fcf8ff", "#f7eeff"],
                },
              },
            },
          },
          markers: {
            size: 6,
            colors: ["#fff"],
            strokeColor: [primary],
            strokeWidth: 3,
          },
          yaxis: {
            tickAmount: 7,
            labels: {
              formatter: function (val, i) {
                if (i % 2 === 0) {
                  return val;
                } else {
                  return "";
                }
              },
            },
          },
          tooltip: {
            y: {
              formatter: function (val) {
                return val;
              },
            },
          },
        },
        series: [
          {
            name: "Market value",
            data: [20, 100, 40, 30, 50, 80, 33],
          },
        ],
      },
    };
  },
  mounted() {
    document.getElementById("ordervalue").append(ordervalue);
    document.getElementById("productvalue").append(productvalue);
  },
  beforeDestroy() {
    clearInterval(this.interval)
  },
  created() {
    this.interval = setInterval(() => {
      this.time = Intl.DateTimeFormat(navigator.language, {
        hour: 'numeric',
        minute: 'numeric',
        second: 'numeric'
      }).format()
    }, 1000)
  }
};
</script>
