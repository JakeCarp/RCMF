<template>
  <div class="container">
    <div class="row">
      <div class="col-md-12">
         <button
            type="button"
            class="btn btn-primary fs-4"
            data-bs-toggle="modal"
            data-bs-target="#createTournament"
          >
            Create Tournament
          </button>
      </div>
      <div class="col-md-12 text-center">
        <p class="display-3 roboto">Tournament Details</p>
      </div>
    </div>
  </div>
</template>

<script>
import { computed } from "@vue/reactivity";
import { onMounted, ref, watchEffect } from "vue";

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
