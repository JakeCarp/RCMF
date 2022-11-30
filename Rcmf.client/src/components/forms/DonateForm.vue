<template>
  <div class="">
    <div class="rounded d-flex justify-content-center">
      <div class="col-md-8 col-sm-12 shadow-lg p-5 bg-light">
        <div class="text-center">
          <h3 class="text-primary abril">Donation Form</h3>
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
            <div class="form-floating mb-3">
              <input
                type="number"
                class="form-control"
                id="floatingInput"
                placeholder="name@example.com"
                required
                min="1"
                v-model="editable.amount"
              />
              <label for="floatingInput">Amount </label>
            </div>

            <button
              class="btn btn-outline-success text-center mt-2 p-3 px-5"
              type="submit"
            >
              Sign Up
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
      async handleSubmit(){
        try {
              if (await Pop.confirm(`name: ${editable.value.name} ` + `email: ${editable.value.email} ` +`amount: ${editable.value.amount} $` )) {
                   
                await donationsService.createDonor(editable.value)
                    }
            Pop.success('Thank you for donating, It is genuinely appreciated')
          } catch (error) {
            Pop.error(error,'[createDonor]')
          }
      }
    };
  },
};
</script>

<style lang="scss" scoped></style>
