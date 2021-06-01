<template>
	<div>
        <br><br>
			<div class="container-fluid p-l-50">
				<div class="row">
					<div class="col-4">
						<div class="default-according style-1 faq-accordion job-accordion" id="accordionoc">
							<div class="row">
								<div class="col-xl-12">
									<b-card no-body>
										<b-card-header header-tag="div" role="tab">
											<h5 class="mb-0">
												<b-button class="btn btn-link pl-0" block v-b-toggle.collapseicon>İş Türüne Göre</b-button>
											</h5>
										</b-card-header>
										<b-collapse id="collapseicon" visible role="tabpanel">
											<b-card-body class="filter-cards-view animate-chk">
												<div class="job-filter">
													<div class="faq-form">
														<input class="form-control" type="text" placeholder="Ara.."><feather class="search-icon" type="search"></feather>
													</div>
												</div>
												<div class="checkbox-animated">
													<label class="d-block" for="chk-ani">
														<input class="checkbox_animated" id="chk-ani" type="checkbox"> Full-time (8688)
													</label>
													<label class="d-block" for="chk-ani1">
														<input class="checkbox_animated" id="chk-ani1" type="checkbox"> Contract (503)
													</label>
													<label class="d-block" for="chk-ani2">
														<input class="checkbox_animated" id="chk-ani2" type="checkbox"> Part-time (288)
													</label>
													<label class="d-block" for="chk-ani3">
														<input class="checkbox_animated" id="chk-ani3" type="checkbox"> Internship (236)
													</label>
													<label class="d-block" for="chk-ani4">
														<input class="checkbox_animated" id="chk-ani4" type="checkbox">  Temporary (146)
													</label>
													<label class="d-block" for="chk-ani5">
														<input class="checkbox_animated" id="chk-ani5" type="checkbox"> Commission (25)
													</label>
												</div>
												<button class="btn btn-primary text-center" type="button">Filtrele</button>
											</b-card-body>
										</b-collapse>
									</b-card>
								</div>
								<div class="col-xl-12">
									<b-card no-body>
										<b-card-header header-tag="div" role="tab">
											<h5 class="mb-0">
												<b-button class="btn btn-link pl-0" block v-b-toggle.collapselocation>Lokasyon</b-button>
											</h5>
										</b-card-header>
										<b-collapse id="collapselocation" visible role="tabpanel">
											<b-card-body class="animate-chk">
												<div class="location-checkbox">
													<label class="d-block" for="chk-ani21">
														<input class="checkbox_animated" id="chk-ani21" type="checkbox">Letraset<span class="d-block">New York, NY (399)</span>
													</label>
													<label class="d-block" for="chk-ani22">
														<input class="checkbox_animated" id="chk-ani22" type="checkbox">Established<span class="d-block">San Francisco, CA (252)</span>
													</label>
													<label class="d-block mb-0" for="chk-ani23">
														<input class="checkbox_animated" id="chk-ani23" type="checkbox">Contrary<span class="d-block">Washington, DC (226)</span>
													</label>
												</div>
												<button class="btn btn-block btn-primary text-center m-t-30" type="button">Filtrele</button>
											</b-card-body>
										</b-collapse>
									</b-card>
								</div>
								<div class="col-xl-12">
									<b-card no-body>
										<b-card-header header-tag="div" role="tab">
											<h5 class="mb-0">
												<b-button class="btn btn-link pl-0" block v-b-toggle.jobtitle>İş Tanımı</b-button>
											</h5>
										</b-card-header>
										<b-collapse id="jobtitle" visible role="tabpanel">
											<b-card-body class="animate-chk">
												<div class="location-checkbox">
													<label class="d-block" for="chk-ani6">
														<input class="checkbox_animated" id="chk-ani6" type="checkbox">UI/Ux designer(25)
													</label>
													<label class="d-block" for="chk-ani7">
														<input class="checkbox_animated" id="chk-ani7" type="checkbox">Graphic designer(10)
													</label>
													<label class="d-block" for="chk-ani8">
														<input class="checkbox_animated" id="chk-ani8" type="checkbox">Front end designer(15)
													</label>
													<label class="d-block" for="chk-ani9">
														<input class="checkbox_animated" id="chk-ani9" type="checkbox">PHP developer(42)
													</label>
													<label class="d-block mb-0" for="chk-ani10">
														<input class="checkbox_animated" id="chk-ani10" type="checkbox">React Developer(5)
													</label>
												</div>
												<button class="btn btn-block btn-primary text-center m-t-30" type="button">Filtrele</button>
											</b-card-body>
										</b-collapse>
									</b-card>
								</div>
								<div class="col-xl-12">
									<b-card no-body>
										<b-card-header header-tag="div" role="tab">
											<h5 class="mb-0">
												<b-button class="btn btn-link pl-0" block v-b-toggle.industry>Sektör</b-button>
											</h5>
										</b-card-header>
										<b-collapse id="industry" visible role="tabpanel">
											<b-card-body class="animate-chk">
												<label class="d-block" for="chk-ani11">
													<input class="checkbox_animated" id="chk-ani11" type="checkbox">Computer Software(14)
												</label>
												<label class="d-block" for="chk-ani12">
													<input class="checkbox_animated" id="chk-ani12" type="checkbox">IT Engineer(10)
												</label>
												<label class="d-block" for="chk-ani13">
													<input class="checkbox_animated" id="chk-ani13" type="checkbox">Service industry(20)
												</label>
												<label class="d-block" for="chk-ani14">
													<input class="checkbox_animated" id="chk-ani14" type="checkbox">Accounting(34)
												</label>
												<label class="d-block mb-0" for="chk-ani15">
													<input class="checkbox_animated" id="chk-ani15" type="checkbox">Financial Services(5)
												</label>
												<button class="btn btn-block btn-primary text-center m-t-30" type="button">Filtrele</button>
											</b-card-body>
										</b-collapse>
									</b-card>
								</div>
							</div>
						</div>
					</div>
					<div class="col-8">
						<div class="row">
							<div class="col-6">
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
												<div class="row m-b-10">
													<div class="col-9">
														<h7 class="fw-bold">Burak Güldiken</h7><br>
													</div>
													<div class="col-3">
														<b-button id="default-sm-primary" variant="primary" size="xs">Başvur</b-button>
													</div>
												</div>
											<small>İstanbul/Kozyatağındaki ofisimiz için full stack developer arayışımız...</small>
											</div>
										</div>
									</div>
									<div slot="footer">
										<span>17 Mayıs 2021</span>
										<span class="pull-right">
											<i class="icofont icofont-eye-alt"><small class="text-muted m-l-5">77 Başvuru</small></i>
										</span>
									</div>
								</px-card>
							</div>
							<div class="col-6">
								<px-card :actions="false" class="features-faq product-box">
									<div slot="headerCustom">
										<div class="base product-img" style="height:200px">
											<img style="width:100%;height:100%" class="" src="../../assets/images/job-search/java.png" alt=""/>
										</div>
									</div>
									<div slot="with-padding">
										<div class="row">
											<div class="col-3">
												<img class="img-50 rounded-circle shadow-lg m-b-10" :src='"../../assets/images/dashboard/myimage.jpeg"' alt=""/>
											</div>
											<div class="col-9">
												<div class="row m-b-10">
													<div class="col-9">
														<h7 class="fw-bold">Burak Güldiken</h7><br>
													</div>
													<div class="col-3">
														<b-button id="default-sm-primary" variant="primary" size="xs">Başvur</b-button>
													</div>
												</div>
											<small>İstanbul/Kozyatağındaki ofisimiz için full stack developer arayışımız...</small>
											</div>
										</div>
									</div>
									<div slot="footer">
										<span>26 Ocak 2021</span>
										<span class="pull-right">
											<i class="icofont icofont-eye-alt"><small class="text-muted m-l-5">150 Başvuru</small></i>
										</span>
									</div>
								</px-card>
							</div>
							<div class="col-6">
								<px-card :actions="false" class="features-faq product-box">
									<div slot="headerCustom">
										<div class="base product-img" style="height:200px">
											<img style="width:100%;height:100%" class="" src="../../assets/images/job-search/dotnet.jpg" alt=""/>
										</div>
									</div>
									<div slot="with-padding">
										<div class="row">
											<div class="col-3">
												<img class="img-50 rounded-circle shadow-lg m-b-10" :src='"../../assets/images/dashboard/myimage.jpeg"' alt=""/>
											</div>
											<div class="col-9">
												<div class="row m-b-10">
													<div class="col-9">
														<h7 class="fw-bold">Burak Güldiken</h7><br>
													</div>
													<div class="col-3">
														<b-button id="default-sm-primary" variant="primary" size="xs">Başvur</b-button>
													</div>
												</div>
											<small>İstanbul/Kozyatağındaki ofisimiz için full stack developer arayışımız...</small>
											</div>
										</div>
									</div>
									<div slot="footer">
										<span>17 Temmuz 2021</span>
										<span class="pull-right">
											<i class="icofont icofont-eye-alt"><small class="text-muted m-l-5">100 Başvuru</small></i>
										</span>
									</div>
								</px-card>
							</div>
							<div class="col-6">
								<px-card :actions="false" class="features-faq product-box">
									<div slot="headerCustom">
										<div class="base product-img" style="height:200px">
											<img style="width:100%;height:100%" class="" src="../../assets/images/job-search/frontend.jpg" alt=""/>
										</div>
									</div>
									<div slot="with-padding">
										<div class="row">
											<div class="col-3">
												<img class="img-50 rounded-circle shadow-lg m-b-10" :src='"../../assets/images/dashboard/myimage.jpeg"' alt=""/>
											</div>
											<div class="col-9">
												<div class="row m-b-10">
													<div class="col-9">
														<h7 class="fw-bold">Burak Güldiken</h7><br>
													</div>
													<div class="col-3">
														<b-button id="default-sm-primary" variant="primary" size="xs">Başvur</b-button>
													</div>
												</div>
											<small>İstanbul/Kozyatağındaki ofisimiz için full stack developer arayışımız...</small>
											</div>
										</div>
									</div>
									<div slot="footer">
										<span>1 Mayıs 2021</span>
										<span class="pull-right">
											<i class="icofont icofont-eye-alt"><small class="text-muted m-l-5">9 Başvuru</small></i>
										</span>
									</div>
								</px-card>
							</div>
							<div class="col-6">
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
												<div class="row m-b-10">
													<div class="col-9">
														<h7 class="fw-bold">Burak Güldiken</h7><br>
													</div>
													<div class="col-3">
														<b-button id="default-sm-primary" variant="primary" size="xs">Başvur</b-button>
													</div>
												</div>
											<small>İstanbul/Kozyatağındaki ofisimiz için full stack developer arayışımız...</small>
											</div>
										</div>
									</div>
									<div slot="footer">
										<span>17 Haziran 2021</span>
										<span class="pull-right">
											<i class="icofont icofont-eye-alt"><small class="text-muted m-l-5">1500 Başvuru</small></i>
										</span>
									</div>
								</px-card>
							</div>
							<div class="col-6">
								<px-card :actions="false" class="features-faq product-box">
									<div slot="headerCustom">
										<div class="base product-img" style="height:200px">
											<img style="width:100%;height:100%" class="" src="../../assets/images/job-search/backend.png" alt=""/>
										</div>
									</div>
									<div slot="with-padding">
										<div class="row">
											<div class="col-3">
												<img class="img-50 rounded-circle shadow-lg m-b-10" :src='"../../assets/images/dashboard/myimage.jpeg"' alt=""/>
											</div>
											<div class="col-9">
												<div class="row m-b-10">
													<div class="col-9">
														<h7 class="fw-bold">Burak Güldiken</h7><br>
													</div>
													<div class="col-3">
														<b-button id="default-sm-primary" variant="primary" size="xs">Başvur</b-button>
													</div>
												</div>
											<small>İstanbul/Kozyatağındaki ofisimiz için full stack developer arayışımız...</small>
											</div>
										</div>
									</div>
									<div slot="footer">
										<span>10 Mayıs 2021</span>
										<span class="pull-right">
											<i class="icofont icofont-eye-alt"><small class="text-muted m-l-5">99 Başvuru</small></i>
										</span>
									</div>
								</px-card>
							</div>
							<div class="col-6">
								<px-card :actions="false" class="features-faq product-box">
									<div slot="headerCustom">
										<div class="base product-img" style="height:200px">
											<img style="width:100%;height:100%" class="" src="../../assets/images/job-search/php.png" alt=""/>
										</div>
									</div>
									<div slot="with-padding">
										<div class="row">
											<div class="col-3">
												<img class="img-50 rounded-circle shadow-lg m-b-10" :src='"../../assets/images/dashboard/myimage.jpeg"' alt=""/>
											</div>
											<div class="col-9">
												<div class="row m-b-10">
													<div class="col-9">
														<h7 class="fw-bold">Burak Güldiken</h7><br>
													</div>
													<div class="col-3">
														<b-button id="default-sm-primary" variant="primary" size="xs">Başvur</b-button>
													</div>
												</div>
											<small>İstanbul/Kozyatağındaki ofisimiz için full stack developer arayışımız...</small>
											</div>
										</div>
									</div>
									<div slot="footer">
										<span>10 Mayıs 2021</span>
										<span class="pull-right">
											<i class="icofont icofont-eye-alt"><small class="text-muted m-l-5">99 Başvuru</small></i>
										</span>
									</div>
								</px-card>
							</div>
							<div class="col-6">
								<px-card :actions="false" class="features-faq product-box">
									<div slot="headerCustom">
										<div class="base product-img" style="height:200px">
											<img style="width:100%;height:100%" class="" src="../../assets/images/job-search/salesmanager.jpg" alt=""/>
										</div>
									</div>
									<div slot="with-padding">
										<div class="row">
											<div class="col-3">
												<img class="img-50 rounded-circle shadow-lg m-b-10" :src='"../../assets/images/dashboard/myimage.jpeg"' alt=""/>
											</div>
											<div class="col-9">
												<div class="row m-b-10">
													<div class="col-9">
														<h7 class="fw-bold">Burak Güldiken</h7><br>
													</div>
													<div class="col-3">
														<b-button id="default-sm-primary" variant="primary" size="xs">Başvur</b-button>
													</div>
												</div>
											<small>İstanbul/Kozyatağındaki ofisimiz için full stack developer arayışımız...</small>
											</div>
										</div>
									</div>
									<div slot="footer">
										<span>10 Mayıs 2021</span>
										<span class="pull-right">
											<i class="icofont icofont-eye-alt"><small class="text-muted m-l-5">99 Başvuru</small></i>
										</span>
									</div>
								</px-card>
							</div>
                        </div>
						<div class="job-pagination m-t-50">
							<nav aria-label="Page navigation example">
								<ul class="pagination pagination-primary">
									<li class="page-item disabled"><a class="page-link" href="#"><span class="txt-dark">Önceki Sayfa</span></a></li>
									<li class="page-item active"><a class="page-link" href="#">1</a></li>
									<li class="page-item"><a class="page-link" href="#">2</a></li>
									<li class="page-item"><a class="page-link" href="#">3</a></li>
									<li class="page-item"><a class="page-link" href="#">4</a></li>
									<li class="page-item"><a class="page-link" href="#">5</a></li>
									<li class="page-item"><a class="page-link" href="#"><span class="txt-dark">Sonraki Sayfa</span></a></li>
								</ul>
							</nav>
						</div>
                    </div>
				</div>
			</div>
			<!-- Container-fluid Ends-->
	</div>
</template>

<script>
import { mapState } from "vuex";
export default {
    name:'JobList',
	computed: {
		...mapState({
            jobslist: state => state.jobs.jobs,
		})
	},
    methods:{
		getImgUrl(filename) {
			var images = require.context('../../assets/images/job-search/', false, /\.jpg$/)
			return images('./' + filename)
		},
		stars(count)
		{
			var stars = ""

			for (var i = 0; i < 5; i++)
			{
				if(count > i)
				{
					stars = stars + '<i class="fa fa-star font-warning"></i>';
				}
				else
				{
					stars = stars + '<i class="fa fa-star font-warning-o"></i>';
				}
			}

			return stars;
		},
		jobDetailPage() {
			this.$router.push({name:'Detail',params: { id: 1 }});
		}
	}
}
</script>

<style scoped>
.job-image {
	width: 100%;
  	height: 275px;
}
</style>