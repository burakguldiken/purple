<template>
    <div>
        <br><br>
        <div class="container-fluid">
            <div class="row">
                <div class="col-6">
                    <div class="knowledgebase-search">
                        <div>
                        <h3>Choose the Package You Want Start Using Now</h3>
                        <p class="text-muted mt-3 mb-0">You can reach thousands of candidates by posting your advertisements.</p>
                        </div>
                    </div>
                </div>
                <div class="col-6">
                    <div class="knowledgebase-bg">
                        <img
                        class="bg-img-cover bg-center"
                        src="../../assets/images/pricing1.png"
                        alt="looginpage"
                        />
                    </div>
                </div>
            </div>
            <div class="row">
              <div class="col-sm-12">
                <px-card title="Packages">
                  <div slot="with-padding">
                    <div class="row">
                    <div class="col-md-4 col-sm-6">
                      <div class="pricingtable">
                        <div class="pricingtable-header">
                          <h3 class="title">Standard</h3>
                        </div>
                        <div class="price-value"><span class="currency">$</span><span class="amount">1</span><span class="duration">/Unlimited</span></div>
                        <ul class="pricing-content">
                          <li>1 Posting Right</li>
                          <li>No Time Limit</li>
                          <li>Unlimited Email Rights</li>
                          <li>Lifetime support</li>
                        </ul>
                        <div><b-button v-b-modal.modal-lg variant="primary">Purchase</b-button></div>
                      </div>
                    </div>
                    <div class="col-md-4 col-sm-6">
                      <div class="pricingtable">
                        <div class="pricingtable-header">
                          <h3 class="title">Bronz</h3>
                        </div>
                        <div class="price-value"><span class="currency">$</span><span class="amount">5</span><span class="duration">/Unlimited</span></div>
                        <ul class="pricing-content">
                          <li>10 Posting Right</li>
                          <li>No Time Limit</li>
                          <li>Unlimited Email Rights</li>
                          <li>Lifetime support</li>
                        </ul>
                        <div><b-button v-b-modal.modal-lg variant="primary">Purchase</b-button></div>
                      </div>
                    </div>
                    <div class="col-md-4 col-sm-6">
                      <div class="pricingtable">
                        <div class="pricingtable-header">
                          <h3 class="title">Premium</h3>
                        </div>
                        <div class="price-value"><span class="currency">$</span><span class="amount">9</span><span class="duration">/Unlimited</span></div>
                        <ul class="pricing-content">
                          <li>Unlimited Advertisement Rights</li>
                          <li>No Time Limit</li>
                          <li>Unlimited Email Rights</li>
                          <li>Lifetime support</li>
                        </ul>
                        <div><b-button v-b-modal.modal-lg variant="primary">Purchase</b-button></div>
                        <b-modal icon="calendar" id="modal-lg" size="lg" title="Payment" class="theme-modal">
                          <div class="row">
                            <div class="col-xl-12">
                              <div class="card height-equal">
                                <div class="card-body">
                                  <div class="row">
                                    <div class="col-md-6 text-center"><img class="img-fluid" src="../../assets/images/ecommerce/card.png" alt=""></div>
                                    <div class="col-md-6">
                                      <form class="theme-form mega-form">
                                        <div class="form-group">
                                          <input class="form-control" type="text" placeholder="Card Number">
                                        </div>
                                        <div class="form-group">
                                          <input class="form-control" type="text" placeholder="Holder Name">
                                        </div>
                                        <div class="form-group">
                                          <input placeholder="Expiration Date" class="form-control" type="date">
                                        </div>
                                        <div class="form-group">
                                          <input class="form-control" type="text" placeholder="Cvv">
                                        </div>
                                        <div>
                                          <div class="table-responsive invoice-table" id="table">
                                            <table class="table table-bordered table-striped">
                                              <tbody>
                                                <tr>
                                                  <td class="Rate">
                                                    <h6 class="mb-0 p-2">Total :</h6>
                                                  </td>
                                                  <td class="payment digits">
                                                    <h6 class="mb-0 p-2">9$</h6>
                                                  </td>
                                                </tr>
                                              </tbody>
                                            </table>
                                          </div>
                                        </div>
                                      </form>
                                    </div>
                                  </div>
                                </div>
                              </div>
                            </div>
                          </div>
                        </b-modal>
                      </div>
                    </div>
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
}
</script>