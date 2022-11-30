<template>
  <div class="">
    <div class="rounded d-flex justify-content-center">
      <div class="col-md-8 col-sm-12 shadow-lg p-5 bg-light">
        <div class="text-center">
          <h3 class="text-primary abril">SponsorShip Form</h3>
        </div>

        <form @submit.prevent="handleSubmit()">
          <div class="p-4">
            <div class="form-floating mb-3">
              <input
                type="text"
                class="form-control"
                id="floatingName"
                placeholder="Name"
                v-model="editable.name"
              />
              <label for="floatingName">Sponsor Name</label>
            </div>

            <div class="form-floating mb-3">
              <input
                type="text"
                class="form-control"
                id="floatingInput"
                placeholder="name@example.com"
                v-model="editable.email"
              />
              <label for="floatingInput">Email </label>
            </div>
            <div class="form-floating mb-3">
              
        <div class="dropdown">
  <button class="btn btn-outline-dark dropdown-toggle" type="button" data-bs-toggle="dropdown" aria-expanded="false">
    Dropdown button
  </button>
  <select class="dropdown-menu p-2" v-model="editable.tier">
    <option class="list-group-item p-2 selectable rounded" :value="t"   v-for="t in tiers"> {{t}} </option>

  </select>
</div>
            </div>
<div class="d-flex justify-content-end">

  <button
    class="btn btn-outline-success text-center mt-2 p-3 px-5"
    type="submit"
  >
    Sign Up
  </button>
</div>
            <!-- <p class="text-center mt-5">
              Don't have an account?
              <span class="text-primary">Sign Up</span>
            </p>
            <p class="text-center text-primary">Forgot your password?</p> -->
          </div>
        </form>
      </div>
    </div>
  </div>
</template>

<script>
import { computed } from "@vue/reactivity";
import { onMounted, ref, watchEffect } from "vue";
import { AppState } from "../../AppState.js";
import { sponsorsService } from "../../services/SponsorsService.js";
import { logger } from "../../utils/Logger.js";
import Pop from "../../utils/Pop.js";
export default {
  props: {},
  setup(props) {
    const editable = ref({});

    onMounted(() => {});
    watchEffect(() => {});

    return {
      editable,
      tiers:computed(() => AppState.sponsorTiers),
     async  handleSubmit(){
        try {
        await sponsorsService.createSponsor(editable.value)
        Pop.success()
          } catch (error) {
            Pop.error(error,'[createSponsor]')
          }
      }
    };
  },
};
</script>

<style lang="scss" scoped></style>
