<template>
  <div class="container">
    <div class="row">
      <div class="col-md-12 d-flex justify-content-center">
        <img
          src="https://images-ext-2.discordapp.net/external/VUMO-JdjQhpPTHQGzprkkSXOMheJUjAd0HYChhUwTLM/https/s3.amazonaws.com/gs-waymarking-images/03a76656-afe3-44cf-8894-9aaf0a305b2f_l.jpg?width=693&height=468"
          alt="Firefighter Statue" class="rounded m-4 elevation-5">
      </div>
    </div>


    <div class="row my-5 navPanel bg-secondary">
      <div class="col-md-12 p-4">
        <nav>
          <div class="nav nav-tabs justify-content-around" id="nav-tab" role="tablist">
            <button class="nav-link active bg-dark navButton" id="nav-home-tab" data-bs-toggle="tab"
              data-bs-target="#nav-home" type="button" role="tab" aria-controls="nav-home" aria-selected="true">What Am
              I Supporting?</button>
            <button class="nav-link bg-dark navButton" id="nav-profile-tab" data-bs-toggle="tab"
              data-bs-target="#nav-profile" type="button" role="tab" aria-controls="nav-profile"
              aria-selected="false">Who Is Randy Carpenter?</button>
            <button class="nav-link bg-dark navButton" id="nav-contact-tab" data-bs-toggle="tab"
              data-bs-target="#nav-contact" type="button" role="tab" aria-controls="nav-contact"
              aria-selected="false">Contact Information</button>
          </div>
        </nav>
        <div class="tab-content" id="nav-tabContent">
          <div class="tab-pane fade show active" id="nav-home" role="tabpanel" aria-labelledby="nav-home-tab"
            tabindex="0">
            <!-- tab1 -->



            <!-- !tab1 -->
          </div>
          <div class="tab-pane fade" id="nav-profile" role="tabpanel" aria-labelledby="nav-profile-tab" tabindex="0">

            About Randy <img src="http://ourfallenbrother.org/pictures/randy.jpg" alt="Randy E Carepenter"
              class="elevation-5 rounded">
          </div>
          <div class="tab-pane fade" id="nav-contact" role="tabpanel" aria-labelledby="nav-contact-tab" tabindex="0">
            Apply For A Grant <img
              src="https://images.unsplash.com/photo-1632844281300-7ce850388164?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
              alt="plane putting out fire" class="elevation-5 rounded twofiremen">

          </div>
          <div class="tab-pane fade" id="nav-disabled" role="tabpanel" aria-labelledby="nav-disabled-tab" tabindex="0">


          </div>
        </div>
      </div>
    </div>



  </div>
</template>

<script>
export default {
  setup() {
    return {

    }
  }
}
</script>
<style>
.navPanel {
  height: 90vh;
  width: auto;
}

.coosbay {
  height: 15rem;
  width: 15rem;
}

.twofiremen {
  height: 16rem;
  width: 16.5rem;
}

.navButton {
  width: 20rem;
}
</style>
