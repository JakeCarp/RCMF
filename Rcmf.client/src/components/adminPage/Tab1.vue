<template>
  <div class="container p-4">
    <div class="row">
      <div class="col-md-12 d-flex justify-content-evenly">
        <div class="card bg-danger border-0 p-3 elevation-6">
          <div>Admin Name/</div>
        </div>

        <div class="card bg-success border-0 mb-4 p-3 elevation-6">
          <div class="card-body">This Month's Donations</div>
        </div>
        <div class="card bg-primary border-0 p-3 elevation-6">
          <div class="card-body">Donors Amount & Shirt sizes</div>
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
