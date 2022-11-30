<template>
  <div class="container p-4">
    <div class="row">
      <div class="col-md-12 d-flex justify-content-evenly">
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

      .
    </div>
    <div class="row">
      <div class="col-md-6">
        <div class="card p-3 elevation-6 border-0">
          <div class="d-flex justify-content-between">
            <p class="fw-bold">Recent Donors</p>
            <p>{{ new Date().toLocaleDateString() }}</p>
          </div>
          <div class="d-flex justify-content-center">
            <img
              src="https://cdn-icons-png.flaticon.com/512/1692/1692130.png"
              alt=""
              width="150"
            />
          </div>
          <div class="card p-3 elevation-2 border d-flex justify-content-evenly ">
            <div class="d-flex justify-content-around">
              <p>Donor Name:</p>
               <p> Amount:{{}} </p>

            </div>
          </div>
        </div>
      </div>
     <div class="col-md-6">
        <div class="card p-3 elevation-6 border-0">
          <div class="d-flex justify-content-between">
            <p class="fw-bold">Grant Applications</p>
           
          </div>
          <div class="d-flex justify-content-center">
            <img
              src="https://cdn-icons-png.flaticon.com/512/1692/1692130.png"
              alt=""
              width="150"
            />
          </div>
          <div class="card p-3 elevation-2 border d-flex justify-content-evenly ">
            <div class="d-flex justify-content-around">
              <p>Donor Name:</p>
               <p> Amount:{{}} </p>

            </div>
          </div>
        </div>
      </div>
        <div class="col-md-6">
        <div class="card p-3 elevation-6 border-0">
          <div class="d-flex justify-content-between">
            <p class="fw-bold">SPONSORS</p>
           
          </div>
          <div class="d-flex justify-content-center">
            <img
              src="https://cdn-icons-png.flaticon.com/512/1692/1692130.png"
              alt=""
              width="150"
            />
          </div>
          <div class="card p-3 elevation-2 border d-flex justify-content-evenly ">
            <div class="d-flex justify-content-around">
              <p v-for="s in sponsors">Sponsor Name:  {{s}}</p>
               <p> Amount:{{}} </p>

            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { computed } from "@vue/reactivity";
import { onMounted, ref, watchEffect } from "vue";
import { AppState } from "../../AppState.js";
import Pop from "../../utils/Pop.js";

export default {
  props: {},
  setup(props) {
    const editable = ref({});

    onMounted(() => {});
    watchEffect(() => {});

    return {
      editable,
      sponsors: computed(() => AppState.sponsors),
    };
  },
};
</script>

<style lang="scss" scoped></style>
