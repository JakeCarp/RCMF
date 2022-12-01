<template>
  <div class="container p-4">
    <div class="row">
      <!-- <div class="col-md-12 d-flex justify-content-evenly">
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

       -->
    </div>
    <div class="row g-2">
      <div class="col-md-3 mb-3">
        <div class="card">
          <button
            type="button"
            class="btn btn-primary fs-4"
            data-bs-toggle="modal"
            data-bs-target="#createTournament"
          >
            Create Tournament
          </button>
        </div>
      </div>
      <div class="col-md-3 mb-3">
        <div class="card">
        
    <button
            type="button"
            class="btn btn-primary fs-4"
          
          >
           Send Mass Email
          </button>
        
      
        </div>
      </div>
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
          <div
            class="card p-3 elevation-2 border d-flex justify-content-evenly"
          >
            <div class="d-flex justify-content-around">
              <p>Donor Name:</p>
              <p>Amount:{{}}</p>
            </div>
          </div>
        </div>
      </div>
      <div class="col-md-6">
        <div class="card p-3 elevation-6 border-0 ">
          <div class="">
          <p class="mb-0 text-muted">  Total Count since  {{new Date().toLocaleDateString()}}</p>
          </div>
          <div class=" justify-content-center p-2 d-flex ">
            <div>

              <img src="https://cdn-icons-png.flaticon.com/512/639/639365.png" alt="" width="75" height="75">
            </div>
          
                <p class="fw-bold roboto fs-3" v-if="donors"> Total ${{total}}</p>
          </div>
      

          <div
            class="card p-1 elevation-2 border d-flex justify-content-evenly scrollY"
          >
          
            <div
              class="d-flex justify-content-around p-2 rounded selectable"
              v-for="d in donors"
            >
          
              <p>{{ d.name }}</p>
              <p>{{ d.email }}</p>
              <p>${{ d.amount }}</p>
              <p>{{ new Date(d.createdAt ).toLocaleString()}}</p>
            </div>
          </div>
        </div>
      </div>




      <div class="col-md-6">
        <div class="card p-3 elevation-6 border-0 ">
          <div class="d-flex justify-content-between">
            <p class="fw-bold"> Sponsors</p>
            <img src="https://cdn-icons-png.flaticon.com/512/1672/1672241.png" alt="" width="100" height="100">
          </div>
   
          <div
            class="card p-1 elevation-2 border d-flex justify-content-evenly"
          >
            <div
              class="d-flex justify-content-around p-2 rounded selectable"
              v-for="s in sponsors"
            >
              <p>{{}}</p>
              <p>{{ s.name }}</p>
              <p>{{ s.email }}</p>
              <p>{{ s.tier }}</p>
              <p>{{ s.createdAt }}</p>
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
import TournamentCreateForm from "../forms/TournamentCreateForm.vue";

export default {
  props: {},
  setup(props) {
    const editable = ref({});
    onMounted(() => {});
    watchEffect(() => {});
   
    return {
      editable,
      sponsors: computed(() => AppState.sponsors),
      donors: computed(() => AppState.donors),
      total : computed(()=> AppState.donationTotal),
    };
  },
  components: { TournamentCreateForm },
};
</script>

<style lang="scss" scoped>
.gradient1{
 background: rgb(2,0,36);
background: linear-gradient(90deg, rgba(2,0,36,0.8590029761904762) 0%, rgba(68,207,108,1) 100%);
}
.gradient2{
background: rgb(2,0,36);
background: linear-gradient(90deg, rgba(2,0,36,0.8590029761904762) 0%, rgba(214,64,69,1) 100%);
}
.scrollY{
  height: 30vh;
  width:auto;
  overflow-y: auto;
  overflow-x: hidden;
}

</style>
