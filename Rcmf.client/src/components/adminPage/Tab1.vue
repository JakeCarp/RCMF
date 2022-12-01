<template>
  <div class="container p-4">
    <div class="row">
      <div class="col-md-8">
        <div class="card p-2 elevation-6 border-0">
          <div class="justify-content-between d-flex p-2">
            <p class="fw-bold">Donations</p>
            <img
              src="https://cdn-icons-png.flaticon.com/512/639/639365.png"
              alt=""
              width="75"
              height="75"
            />
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
              <p>{{ new Date(d.createdAt).toLocaleString() }}</p>
              <p>{{ new Date(d.createdAt).getMonth() }}</p>
              <p>{{ new Date(Date.now()).getMonth() + 1 }}</p>
            </div>
          </div>
        </div>
      </div>

      <div class="col-md-4">
        <!-- <VueChart1/> -->
        <div class="card border-0 p-3 elevation-6 text-center">
          <p class="roboto text-muted">
            Total Count since {{ new Date().toLocaleDateString() }}
          </p>
          <p class="roboto display-2 text-shadow2">${{ total }}</p>
          <p class="roboto fs-5 text-shadow2">This Month ${{ monthTotal }}</p>
        </div>
      </div>

      <div class="col-md-6">
        <div class="card p-2 elevation-6 border-0">
          <div class="d-flex justify-content-between p-2">
            <p class="fw-bold">Sponsors</p>
            <img
              src="https://cdn-icons-png.flaticon.com/512/1672/1672241.png"
              alt=""
              width="75"
              height="75"
            />
          </div>

          <div
            class="card p-1 elevation-2 border d-flex justify-content-evenly scrollY"
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
import VueChart1 from "../VueChart1.vue";

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
      total: computed(() => AppState.donationTotal),
      monthTotal: computed(() =>
        AppState.donors.forEach((d) => {
          let current = new Date(Date.now());
          let donorDate = new Date(d.createdAt);

          if (donorDate == current) {
            AppState.monthTotal += d.amount;
          
          }
          return AppState.monthTotal
        })
      ),
    };
  },
  components: { TournamentCreateForm, VueChart1 },
};
</script>

<style lang="scss" scoped>
.gradient1 {
  background: rgb(2, 0, 36);
  background: linear-gradient(
    90deg,
    rgba(2, 0, 36, 0.8590029761904762) 0%,
    rgba(68, 207, 108, 1) 100%
  );
}
.gradient2 {
  background: rgb(2, 0, 36);
  background: linear-gradient(
    90deg,
    rgba(2, 0, 36, 0.8590029761904762) 0%,
    rgba(214, 64, 69, 1) 100%
  );
}
.scrollY {
  height: 30vh;
  width: auto;
  overflow-y: auto;
  overflow-x: hidden;
}
</style>
