<template>
  <div class="mt-5">
    <div class="rounded d-flex justify-content-center">
      <div class="col-md-8 col-sm-12 shadow-lg p-5 bg-light">
        <div class="text-center">
          <h3 class="text-primary">Sign Up form</h3>
        </div>
        <form action="">
          <div class="p-4">
            <div class="input-group mb-3">
             
              <input type="text" class="form-control " placeholder="Name" />
            </div>
            <div class="input-group mb-3">
           
              <input
                type="text"
                class="form-control"
                placeholder="Email"
              />
            </div>
            <div class="input-group mb-3">
           
              <input
                type="text"
                class="form-control"
                placeholder="ShirtSize"
              />
            </div>
            <div class="input-group mb-3">
           
              <input
                type="text"
                class="form-control"
                placeholder="password"
              />
            </div>
            <div class="input-group mb-3">
           
              <input
                type="text"
                class="form-control"
                placeholder="password"
              />
            </div>

            <button class="btn btn-outline-success text-center mt-2 p-3 px-5 " type="submit">
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
import { AppState } from "../AppState.js";
import { logger } from "../utils/Logger.js";
import Pop from "../utils/Pop.js";

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
