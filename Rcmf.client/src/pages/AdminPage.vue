<template>
  <div class="container-fluid mt-4">
    <div class="row">
      <!-- <div class="col-md-3 test d-flex flex-column  justify-content-between ">
     
      </div> -->
<div class="col-md-12 d-flex justify-content-center">
  <h1 class="abril">Admin DashBoard</h1>
</div>
      <div class="col-md-12">
        <!-- NavButtons -->
        <nav>
          <div
            class="nav nav-tabs rounded justify-content-center justify-content-evenly"
            id="nav-tab"
            role="tablist"
          >
            <button
              class="nav-link active"
              id="nav-home-tab"
              data-bs-toggle="tab"
              data-bs-target="#nav-home"
              type="button"
              role="tab"
              aria-controls="nav-home"
              aria-selected="true"
            >
              Home
            </button>
            <button
              class="nav-link"
              id="nav-profile-tab"
              data-bs-toggle="tab"
              data-bs-target="#nav-profile"
              type="button"
              role="tab"
              aria-controls="nav-profile"
              aria-selected="false"
            >
              Profile
            </button>
            <button
              class="nav-link"
              id="nav-contact-tab"
              data-bs-toggle="tab"
              data-bs-target="#nav-contact"
              type="button"
              role="tab"
              aria-controls="nav-contact"
              aria-selected="false"
            >
              Contact
            </button>

            <button
              class="nav-link"
              id="nav-fourth-tab"
              data-bs-toggle="tab"
              data-bs-target="#nav-fourth"
              type="button"
              role="tab"
              aria-controls="nav-fourth"
              aria-selected="false"
            >
              fourth
            </button>
          </div>
        </nav>
        <!-- !NavButtons -->
        <div class="tab-content " id="nav-tabContent">
          <div
            class="tab-pane fade show active"
            id="nav-home"
            role="tabpanel"
            aria-labelledby="nav-home-tab"
            tabindex="0"
          >
          <!-- Tab1 -->
            <div class="container p-4 ">
              <div class="row">
                <div class="col-md-12  d-flex justify-content-evenly">
                  <div class="card bg-danger border-0 p-3 elevation-6">
                    <div>Admin Name/</div>
                  </div>

                  <div class="card bg-success border-0 mb-4 p-3 elevation-6">
                    <div class="card-body">This Month's Donations</div>
                  </div>
                  <div class="card bg-primary border-0 p-3 elevation-6">
                    <div class="card-body">Donors Amount & Shirt sizes</div>
                  </div>
                </div>
              </div>
            </div>
            <!-- !Tab1 -->
          </div>
          <div
            class="tab-pane fade"
            id="nav-profile"
            role="tabpanel"
            aria-labelledby="nav-profile-tab"
            tabindex="0"
          >
            <!-- Tab2 -->
            <!-- !Tab2 -->
          </div>
          <div
            class="tab-pane fade"
            id="nav-contact"
            role="tabpanel"
            aria-labelledby="nav-contact-tab"
            tabindex="0"
          >
            <!-- Tab3 -->
            <!-- !Tab3 -->
          </div>
          <div
            class="tab-pane fade"
            id="nav-fourth"
            role="tabpanel"
            aria-labelledby="nav-fourth-tab"
            tabindex="0"
          >
            <!-- Tab4 -->
            <!-- !Tab4 -->
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { computed } from "vue";
import { AppState } from "../AppState";
export default {
  setup() {
    return {
      account: computed(() => AppState.account),
    };
  },
};
</script>

<style scoped>
.test {
  height: 80vh;
}
img {
  max-width: 100px;
}
nav .active {
  border: 0;
  border-bottom: 5px solid #f5a53c !important;
  background-color: transparent !important;
  font-weight: bold;
}
nav .nav-link {
  color: black !important;
  margin: 0 20px;
  font-size: 1.5rem;
}
</style>
