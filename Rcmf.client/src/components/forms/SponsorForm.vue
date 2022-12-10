<template>
    <form @submit.prevent="handleSubmit()" class="" v-motion-pop :delay="200">
  <div class="my-5">
    <div class="rounded d-flex justify-content-center">
      <div class="col-md-8 col-sm-12 shadow-lg p-5 bg-light">
        <div class="text-center">
          <h3 class="text-primary abril">SponsorShip Form</h3>
        </div>

      
          <div class="p-4">
            <div class="form-floating mb-3">
              <input
                type="text"
                class="form-control"
                id="floatingName"
                placeholder="Name"
                required
            
                v-model="editable.name"
              />
              <label for="floatingName">Sponsor Name</label>
            </div>

            <div class="form-floating mb-3">
              <input
                type="text"
                class="form-control"
                id="floatingInput"
                required
                placeholder="name@example.com"
                v-model="editable.email"
              />
              <label for="floatingInput">Email </label>
            </div>

            <div class="form-floating mb-3">
              <div class="dropdown-top w-100">
                <button
                v-if="!editable.tier"
                class="btn fw-bold fs-5 btn-outline-dark" type="button" data-bs-toggle="offcanvas" data-bs-target="#offcanvasTiers" aria-controls="offcanvasTiers">
 Select A SponsorShip Tier
</button>
<div   v-else class="d-flex">
<p class="p-2 fw-bold fs-3  mb-0">  <img src="https://cdn-icons-png.flaticon.com/512/64/64440.png" alt="" width="40" height="40">  {{editable.tier}}  </p>

       <button
              
                class="btn fw-bold fs-5 btn-outline-dark" type="button" data-bs-toggle="offcanvas" data-bs-target="#offcanvasTiers" aria-controls="offcanvasTiers">
Change Tier
</button>



</div>
         
              </div>
            </div>

            <div class="d-flex justify-content-end">
              <button
                :class="editable.tier? '' : 'disabled text-dark border-dark'"
          
                class="btn btn-outline-success text-center mt-2 p-3 px-5"
                type="submit"
              >
                Sign Up
              </button>
            </div>
          </div>
     
        <div class=" text-muted "><p class="fw-bold mt-3 fs-6">
           The Randy Carpenter Memorial Foundation is a 501c(3) Non-Profit Organization. <br> All donations are tax deductible.
        </p></div>
      </div>
    </div>
  </div>

  <div class="offcanvas offcanvas-start" tabindex="-1" id="offcanvasTiers" aria-labelledby="offcanvasTiersLabel">
  <div class="offcanvas-header">
    <h5 class="offcanvas-title" id="offcanvasTiersLabel">Sponsorship Tiers</h5>
    <button type="button" class="btn-close" data-bs-dismiss="offcanvas" aria-label="Close"></button>
  </div>
  <div class="offcanvas-body">
  
     <ul
                  class=" w-100 border-0   p-3"
            
                >
                  <li
                    class="dropdown-item p-2 fw-bold hover-2 selectable rounded-2 text-wrap"
                    v-for="t in tiers"
                    @click="setTier(t.tier)"
                  >
               
                    <p class="fs-3 mb-0">{{ t.tier }} {{ t.price }}</p>
                    <p>{{ t.text }}</p>
                  </li>
                </ul>
  
  </div>
</div>
   </form>
</template>

<script>
import { computed } from "@vue/reactivity";
import { onMounted, ref, watchEffect } from "vue";
import { AppState } from "../../AppState.js";
import { sponsorsService } from "../../services/SponsorsService.js";
import { logger } from "../../utils/Logger.js";
import Pop from "../../utils/Pop.js";
import LoadingAnimation from "../LoadingAnimation.vue";
import { Offcanvas } from "bootstrap";
export default {
  props: {},
  setup(props) {
    const editable = ref({});
    onMounted(() => {});
    watchEffect(() => {});
    return {
      editable,
      tiers: [
        {
          tier: "Diamond",
          price: "($2,500)",
          text: "Only one Available. This Company is advertised as the Tournament Sponsor on shirts and signage at the BBQ. A company logoed item can be donated for player bags, if desired, two gold teams and eight lunches are included in this sponsorship",
        },
        {
          tier: "Platinum",
          price: "($1,500)",
          text: "This Company is advertised as Major Sponsor on the front page of the website. Sign on the tee box of a hole during the tournament and at the BBQ. Written thank you in all of the player bags. Items with a company logo can be donated for player bags, if desired, Two gold teams and eight lunches included in sponsorship",
        },
        {
          tier: "Gold",
          price: "($500)",
          text: "Sign on the tee box of a hole during the tournament and at the BBQ. Written thank you in all of the player bags. Items with a company logo can be donated for player bags, if desired. One gold team and four lunches included in sponsorship",
        },
        {
          tier: "Silver",
          price: "($350)",
          text: "Sign on the tee box of a hole during the tournament and at the BBQ. Written thank you in all of the player bags. Items with a company logo can be donated for player bags, if desired",
        },
        {
          tier: "Bronze",
          price: "($200)",
          text: "Sign on the tee box of a hole during the tournament and at the BBQ. Items with a company logo can be donated for player bags, if desired",
        },
        {
          tier: "Hole",
          price: "($125)",
          text: "Sign on the tee box of a hole during the tournament. Can attend and set up display at hole, if desired",
        },
        {
          tier: "Prize Donation Items",
          text: "Will be used as prizes/raffle and the donating company will be announced when given away",
        },
      ],
      // tiers:computed(() => AppState.sponsorTiers),
      async handleSubmit() {
        try {
          await sponsorsService.createSponsor(editable.value);
          Pop.success();
        } catch (error) {
          Pop.error(error, "[createSponsor]");
        }
      },
      setTier(tier){
        editable.value.tier=tier
        console.log(editable.value);
        Offcanvas.getOrCreateInstance('#offcanvasTiers').hide()
      }
    };
  },
  components: { LoadingAnimation },
};
</script>

<style lang="scss" scoped>
.scrollableY {
  z-index: 99999;
  height: 50vh;
  overflow-y: auto;
  overflow-x: hidden;
}
</style>
