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
import {
  addDoc,
  collection,
  doc,
  getFirestore,
  setDoc,
} from "firebase/firestore";
import { chats, db } from "../services/FireBaseService.js";
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
          let id = this.generateId();
          let data = {
            text: editable.value.text,
            uid: "633e5b0b5367e0d6e157b8a3",
            photoUrl:
              "https://s.gravatar.com/avatar/2b917e2ca61eeea5a929fa6337bf9de0?s=480&r=pg&d=https%3A%2F%2Fcdn.auth0.com%2Favatars%2Fih.png",
            createdAt: new Date(),
          };
          await setDoc(doc(db, "chats", id), data);
          
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
