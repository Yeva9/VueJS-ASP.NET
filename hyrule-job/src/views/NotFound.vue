<template>
<div class="d-flex align-items-center justify-content-center vh-100 flex-column text-center">
    <div>
        <div class="card text-muted shadow-lg pl-5 pr-5">
            <h2 class="card-header display-1"> 404 </h2>
            <h3 class="card-subtitle m-3"> Page not found </h3>

            <div class="card-body">
                <a class="btn btn-sm btn-info text-white" type="button" href="/"> Back To Home </a>
            </div>
        </div>
    </div>
</div>
</template>
  
<script lang="ts">
import { defineComponent } from 'vue';

export default defineComponent({
  name: 'NotFound'
})
</script>

<style>
</style>
  