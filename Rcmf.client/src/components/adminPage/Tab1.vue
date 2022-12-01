<template>
  <div class="container p-4">
    <div class="row">
      <div class="col-md-8">
        <div class="card p-2 elevation-6 border-0">
         
          <div class="justify-content-between d-flex p-2">
            <p  class="fw-bold ">Donations</p>
            <img
              src="https://cdn-icons-png.flaticon.com/512/639/639365.png"
              alt=""
              width="100"
              height="100"
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
            </div>
          </div>
        </div>
      </div>

      <div class="col-md-6">
        <div class="card p-2 elevation-6 border-0">
          <div class="d-flex justify-content-between p-2">
            <p class="fw-bold">Sponsors</p>
            <img
              src="https://cdn-icons-png.flaticon.com/512/1672/1672241.png"
              alt=""
              width="100"
              height="100"
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
    };
  },
  components: { TournamentCreateForm },
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
