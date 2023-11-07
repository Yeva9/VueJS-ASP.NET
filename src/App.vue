<template>
  <nav>
    <router-link to="/">Home</router-link> |
    <router-link :to="{name: 'aboutt'}">About</router-link>
  </nav>
  <router-view/>
</template>

<script lang="ts">
import { defineComponent} from 'vue';

export default defineComponent({
  name: 'App',
});
</script>

<style>
</style>
