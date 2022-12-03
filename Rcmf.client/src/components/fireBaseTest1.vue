<template>
  <div>
    <form @submit.prevent="post()">
      <textarea v-model="editable.text" name="" id="" cols="30" rows="10">
      </textarea>
      <button type="submit">submit</button>
    </form>
    <div class="card">
      <ul>
        <li v-for="c in chats" :key="c.id" class="list-group-item">
          <img
            :src="c.photoUrl"
            alt=""
            width="40"
            height="40"
            class="rounded-circle"
          />
          <span class="text-dark abril fs-3">{{ c.text }}</span>
          <p class="text-muted">
            {{ new Date(c.createdAt.seconds).toLocaleTimeString() }}
          </p>
        </li>
      </ul>
    </div>
  </div>
</template>

<script>
import { computed } from "@vue/reactivity";
import { onMounted, ref, watchEffect } from "vue";
import { AppState } from "../AppState.js";
import { logger } from "../utils/Logger.js";
import Pop from "../utils/Pop.js";
import { useCollection } from "vuefire";
import { collection, doc, setDoc } from "firebase/firestore";
import { db } from "../services/FireBaseService.js";
import { supabaseService } from "../services/SupabaseService";
import { set } from "@firebase/database";

export default {
  props: {},
  setup(props) {
    const editable = ref({});

    onMounted(() => {});
    watchEffect(() => {});

    const chats = useCollection(collection(db, "chats"));

    return {
      chats,
      editable,

      async post() {
        try {
          // await setDoc(doc(db, "chats",id), editable.value);
        //   await supabaseService.addSupabaseChat(editable.value);
        } catch (error) {
          Pop.error(error, "[]");
        }
      },
      generateId() {
        let timestamp = ((new Date().getTime() / 1000) | 0).toString(16);
        return (
          timestamp +
          "xxxxxxxxxxxxxxxx"
            .replace(/[x]/g, () => ((Math.random() * 16) | 0).toString(16))
            .toLowerCase()
        );
      },
    };
  },
};
</script>

<style lang="scss" scoped></style>
