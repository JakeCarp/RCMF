<template>
  <div class="container">
    <div class="row">
      <div class="col-md-12 d-flex justify-content-center">
        <img
          src="https://images-ext-2.discordapp.net/external/VUMO-JdjQhpPTHQGzprkkSXOMheJUjAd0HYChhUwTLM/https/s3.amazonaws.com/gs-waymarking-images/03a76656-afe3-44cf-8894-9aaf0a305b2f_l.jpg?width=693&height=468"
          alt="Firefighter Statue" class="rounded">
      </div>
    </div>


    <div class="row">
      <div class="col-md-12 d-flex align-items-center">
        <nav>
          <div class="nav nav-tabs" id="nav-tab" role="tablist">
            <button class="nav-link active" id="nav-home-tab" data-bs-toggle="tab" data-bs-target="#nav-home"
              type="button" role="tab" aria-controls="nav-home" aria-selected="true">About Foundation <img
                src="http://ourfallenbrother.org/pictures/memorial.jpg" alt="Coos Bay FireFighters Memorial"
                class="coosbay"></button>
            <button class="nav-link" id="nav-profile-tab" data-bs-toggle="tab" data-bs-target="#nav-profile"
              type="button" role="tab" aria-controls="nav-profile" aria-selected="false">About Randy <img
                src="http://ourfallenbrother.org/pictures/randy.jpg" alt="Randy E Carepenter"></button>
            <button class="nav-link" id="nav-contact-tab" data-bs-toggle="tab" data-bs-target="#nav-contact"
              type="button" role="tab" aria-controls="nav-contact" aria-selected="false">Apply For A Grant <img
                src="http://ourfallenbrother.org/pictures/equipment.jpg" alt="Fireman with a hammer"></button>
          </div>
        </nav>
        <div class="tab-content" id="nav-tabContent">
          <div class="tab-pane fade show active" id="nav-home" role="tabpanel" aria-labelledby="nav-home-tab"
            tabindex="0"></div>
          <div class="tab-pane fade" id="nav-profile" role="tabpanel" aria-labelledby="nav-profile-tab" tabindex="0">
          </div>
          <div class="tab-pane fade" id="nav-contact" role="tabpanel" aria-labelledby="nav-contact-tab" tabindex="0">
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
.coosbay {
  height: 15rem;
  width: 15rem;
}
</style>
