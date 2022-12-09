<template>
  <div class="">
    <div class="rounded d-flex justify-content-center">
      <div class="col-md-8 col-sm-12 shadow-lg p-5 bg-light">
        <div class="text-center">
          <h3 class="text-primary abril">SponsorShip Form</h3>
        </div>

        <LoadingAnimation/>
        <!-- <form @submit.prevent="handleSubmit()">
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
              <div class="dropdown-center w-100">
  <button class="btn text-dark dropdown-toggle w-100 fs-3 bg-transparent" type="button" data-bs-toggle="dropdown" aria-expanded="false">
    Sponsorship Tiers
  </button>
  <ul class="dropdown-menu w-100 border-0 elevation-6">
    <li class="dropdown-item p-2 fw-bold hover-2 selectable rounded-2 text-wrap"> <p class="fs-3 mb-0">Diamond Sponsor($2,500) </p>
       <p>Only one Available. This Company is advertised as the Tournament Sponsor on shirts and signage at the BBQ. A company logoed item can be donated for player bags, if desired, two gold teams and eight lunches are included in this sponsorship</p>  </li>
    <li><a class="dropdown-item" href="#">Action two</a></li>
    <li><a class="dropdown-item" href="#">Action three</a></li>
  </ul>
</div>
            </div>
            <div class="form-floating mb-3">
               <select class=" p-2" v-model="editable.tier">
    <option class="list-group-item p-2 selectable rounded" :value="t"   v-for="t in tiers"> {{t}} </option>

  </select>
   
            </div>
<div class="d-flex justify-content-end">

  <button
    class="btn btn-outline-success text-center mt-2 p-3 px-5"
    type="submit"
  >
    Sign Up
  </button>
</div>
       
          </div>
        </form> -->
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
import LoadingAnimation from "../LoadingAnimation.vue";
export default {
    props: {},
    setup(props) {
        const editable = ref({});
        onMounted(() => { });
        watchEffect(() => { });
        return {
            editable,
            tiers: [
                "Hole",
                "Team",
                "Bronze",
                "Silver",
                "Gold",
                "Platinum",
                { tier: "Diamond", text: "Only one Available. This Company is advertised as the Tournament Sponsor on shirts and signage at the BBQ. A company logoed item can be donated for player bags, if desired, two gold teams and eight lunches are included in this sponsorship" },
                { tier: "Platinum", text: "This Company is advertised as Major Sponsor on the front page of the website. Sign on the tee box of a hole during the tournament and at the BBQ. Written thank you in all of the player bags. Items with a company logo can be donated for player bags, if desired, Two gold teams and eight lunches included in sponsorship" }
            ],
            // tiers:computed(() => AppState.sponsorTiers),
            async handleSubmit() {
                try {
                    await sponsorsService.createSponsor(editable.value);
                    Pop.success();
                }
                catch (error) {
                    Pop.error(error, "[createSponsor]");
                }
            }
        };
    },
    components: { LoadingAnimation }
};
</script>

<style lang="scss" scoped></style>
