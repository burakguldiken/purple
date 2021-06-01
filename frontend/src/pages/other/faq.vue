<template>
  <div>
    <br />
    <div class="container-fluid p-l-50">
      <div class="row">
        <div class="col-6">
          <div class="knowledgebase-search">
            <div>
              <h3>How Can I help you?</h3>
              <form class="form-inline" action="#" method="get">
                <div class="form-group w-100">
                  <i data-feather="search"></i>
                  <input
                    class="form-control-plaintext w-100"
                    type="text"
                    placeholder="Type question here"
                    title=""
                  />
                </div>
              </form>
            </div>
          </div>
        </div>
        <div class="col-6">
          <div class="knowledgebase-bg">
            <img
              class="bg-img-cover bg-center"
              src="../../assets/images/faq/faq2.png"
              alt="looginpage"
            />
          </div>
        </div>
      </div>
      <div class="row">
        <div class="col-xl-4 xl-100">
          <div class="card bg-primary">
            <div class="card-body">
              <div class="media faq-widgets">
                <div class="media-body">
                  <h5>What Is FAQ ?</h5>
                  <p>
                    The term "FAQ", which can be seen on almost every platform on the virtual environment, is wondered by many users who are new to the internet environment and who are new to computer use.
                  </p>
                </div>
                <feather size="45" type="info"></feather>
              </div>
            </div>
          </div>
        </div>
        <div class="col-xl-4 xl-50 col-sm-6">
          <div class="card bg-primary">
            <div class="card-body">
              <div class="media faq-widgets">
                <div class="media-body">
                  <h5>About Us</h5>
                  <p>
                    Purple is a platform where you can open and publish job postings or help you catch job opportunities by applying to existing postings. Here you can also find freelance jobs and develop opportunities.
                  </p>
                </div>
                <feather size="45" type="book-open"></feather>
              </div>
            </div>
          </div>
        </div>
        <div class="col-xl-4 xl-50 col-sm-6">
          <div class="card bg-primary">
            <div class="card-body">
              <div class="media faq-widgets">
                <div class="media-body">
                  <h5>Support</h5>
                  <p>
                    Users can contact us for any errors, problems or complaints they encounter. Average response time is 7-14 business days after the transaction, depending on the intensity of the transaction. 
                  </p>
                </div>
                <feather color="" size="45" type="alert-triangle"></feather>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="col-lg-12">
        <div class="faq-title">
          <h6>Basic</h6>
        </div>
        <div
          class="row default-according style-1 faq-accordion"
          id="accordionoc"
        >
          <div class="col-xl-12 xl-60 col-lg-12 col-md-12">
            <b-card no-body>
              <b-card-header header-tag="div" role="tab">
                <h5 class="mb-0">
                  <button
                    v-b-toggle.collapseicon1
                    class="btn btn-link collapsed"
                  >
                    <feather type="help-circle"></feather>
                    What Can I Do With Purple?
                  </button>
                </h5>
              </b-card-header>
              <b-collapse id="collapseicon1" role="tabpanel">
                <b-card-body
                  >With Purple, you can create advertisements, apply to existing advertisements, send an e-mail to the members who apply through the interface. You can access various data such as the average time you spend, the number of advertisements on the home page. You can plan your work with the calendar.
                </b-card-body
                >
              </b-collapse>
            </b-card>

            <b-card no-body>
              <b-card-header header-tag="div" role="tab">
                <h5 class="mb-0">
                  <button
                    v-b-toggle.collapseicon2
                    class="btn btn-link collapsed"
                  >
                    <feather type="help-circle"></feather>
                    How do I Become A Member?
                  </button>
                </h5>
              </b-card-header>
              <b-collapse id="collapseicon2" role="tabpanel">
                <b-card-body>
                  <a href="http://localhost:8080/authentication/register">http://localhost:8080/authentication/register</a> You can go to and fill in the required information and become a member.
                </b-card-body>
              </b-collapse>
            </b-card>

            <b-card no-body>
              <b-card-header header-tag="div" role="tab">
                <h5 class="mb-0">
                  <button
                    v-b-toggle.collapseicon3
                    class="btn btn-link collapsed"
                  >
                    <feather type="help-circle"></feather>
                    Can I Post As Many Ads As I Want?
                  </button>
                </h5>
              </b-card-header>
              <b-collapse id="collapseicon3" role="tabpanel">
                <b-card-body>
                  The advertisements you can publish vary according to your package type, you can learn from the section below about the package contents.
                </b-card-body>
              </b-collapse>
            </b-card>

            <div class="faq-title">
              <h6>Package</h6>
            </div>

            <b-card no-body>
              <b-card-header header-tag="div" role="tab">
                <h5 class="mb-0">
                  <button
                    v-b-toggle.collapseicon5
                    class="btn btn-link collapsed"
                  >
                    <feather type="help-circle"></feather>
                    What Kinds of Packages Are Available?
                  </button>
                </h5>
              </b-card-header>
              <b-collapse id="collapseicon5" role="tabpanel">
                <b-card-body>
                  There are 3 package options as unlimited package, 10 package and single package. The duration of all packages is unlimited.
                </b-card-body>
              </b-collapse>
            </b-card>

            <b-card no-body>
              <b-card-header header-tag="div" role="tab">
                <h5 class="mb-0">
                  <button
                    v-b-toggle.collapseicon6
                    class="btn btn-link collapsed"
                  >
                    <feather type="help-circle"></feather>
                    How Many Ads Are Free?
                  </button>
                </h5>
              </b-card-header>
              <b-collapse id="collapseicon6" role="tabpanel">
                <b-card-body>
                  In order to publish an ad, it is necessary to buy a package first.
                </b-card-body>
              </b-collapse>
            </b-card>

            <div class="faq-title">
              <h6>Others</h6>
            </div>

            <b-card no-body>
              <b-card-header header-tag="div" role="tab">
                <h5 class="mb-0">
                  <button
                    v-b-toggle.collapseicon8
                    class="btn btn-link collapsed"
                  >
                    <feather type="help-circle"></feather>
                    What is a Calendar, How is it used?
                  </button>
                </h5>
              </b-card-header>
              <b-collapse id="collapseicon8" role="tabpanel">
                <b-card-body>
                  With the calendar, you can create your schedule by naming your works and choosing between the dates. You will be sent an e-mail for upcoming events.
                </b-card-body>
              </b-collapse>
            </b-card>

            <b-card no-body>
              <b-card-header header-tag="div" role="tab">
                <h5 class="mb-0">
                  <button
                    v-b-toggle.collapseicon9
                    class="btn btn-link collapsed"
                  >
                    <feather type="help-circle"></feather>
                    Is There a Gift for the Best Freeworkers?
                  </button>
                </h5>
              </b-card-header>
              <b-collapse id="collapseicon9" role="tabpanel">
                <b-card-body>
                  No, but the best freeworker postings have the privilege of being posted at the top of their category, providing more engagement.
                </b-card-body>
              </b-collapse>
            </b-card>

            <b-card no-body>
              <b-card-header header-tag="div" role="tab">
                <h5 class="mb-0">
                  <button
                    v-b-toggle.collapseicon10
                    class="btn btn-link collapsed"
                  >
                    <feather type="help-circle"></feather>
                    Will new features come to the system in terms of user satisfaction?
                  </button>
                </h5>
              </b-card-header>
              <b-collapse id="collapseicon10" role="tabpanel">
                <b-card-body>
                  Yes, people will be able to add their own projects and create their own portfolio. Studies on this are ongoing.
                </b-card-body>
              </b-collapse>
            </b-card>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>