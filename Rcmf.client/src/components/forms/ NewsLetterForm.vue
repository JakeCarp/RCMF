<template>
  <div class="modal-body image">
    <div class="row justify-content-center">
      <div class="col-md-12">
      <p class="fs-3 fw-bold text-light text-shadow2 abril p-2  ">   Join our Newsletter to receive the latest updates of gatherings and other information</p>
      </div>
      <div class="col-md-8 col-sm-12 shadow-lg p-5 bg-light">
        <div class="text-center">
          <h3 class="text-primary abril">Newsletter</h3>
        </div>
        <form @submit.prevent="handleSubmit()">
          <div class="p-4">
            <div class="form-floating mb-3">
              <input
                type="text"
                class="form-control"
                id="floatingName"
                placeholder="Name"
                required
                minlength="4"
                v-model="editable.name"
              />
              <label for="floatingName">Name</label>
            </div>
            <div class="form-floating mb-3">
              <input
                type="email"
                class="form-control"
                id="floatingInput"
                placeholder="name@example.com"
                required
                minlength="5"
                v-model="editable.email"
              />
              <label for="floatingInput">Email </label>
            </div>
      
            <button
              class="btn btn-outline-success text-center mt-2 p-3 px-5"
              type="submit"
            >
              Sign Up For NewsLetter
            </button>
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
import { donationsService } from "../../services/DonationsService.js";
import { newsLetterService } from "../../services/NewsLetterService.js";
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
      async handleSubmit() {
        try {
     
            await newsLetterService.createSubscriber(editable.value);
          
          Pop.success("Thank you for Joining our Newsletter!");
        } catch (error) {
          Pop.error(error, "[createDonor]");
        }
      },
    };
  },
};
</script>

<style lang="scss" scoped>
.image{
 height: 80vh;
  /* always scale the image to the appropriate size of your screen */
  background-size: cover;
  background-image: url(https://images.unsplash.com/photo-1477414348463-c0eb7f1359b6?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1770&q=80);
  background-position: center;
  /* keeps the image fixed while scrolling , neat effect. */
  background-attachment: fixed; 
}


</style>
