<template>
  <div class="">
    <div class="rounded d-flex justify-content-center">
      <div class="col-md-8 col-sm-12 shadow-lg p-5 bg-light">
        <div class="text-center">
          <h3 class="text-primary">Sign Up form</h3>
        </div>
        <form action="">
          <div class="p-4">
            <div class="form-floating mb-3">
              <input
                type="text"
                class="form-control"
                id="floatingName"
                placeholder="Name"
                required
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
              />
              <label for="floatingInput">Email address</label>
            </div>
            <div class="form-floating mb-3">
              <input
                type="phone"
                class="form-control"
                pattern="^(?:(?:\+?1\s*(?:[.-]\s*)?)?(?:\(\s*([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9])\s*\)|([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9]))\s*(?:[.-]\s*)?)?([2-9]1[02-9]|[2-9][02-9]1|[2-9][02-9]{2})\s*(?:[.-]\s*)?([0-9]{4})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$"
                id="floatingInput"
                placeholder="name@example.com"
                required
              />
              <label for="floatingInput">Phone-Number </label>
            </div>
            <div class="form-floating mb-3">
              <input
                class="form-control"
                id="floatingInput"
                placeholder="XXL"
                required
              />
              <label for="floatingInput">ShirtSize</label>
            </div>
            <div class="form-floating mb-3">
              <input
                type="text"
                class="form-control"
                id="floatingInput"
                placeholder="name@example.com"
                required
              />
              <label for="floatingInput">Address</label>
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
    };
  },
};
</script>

<style lang="scss" scoped></style>
