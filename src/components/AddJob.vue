<template>
    <div class="row justify-content-md-end">
        <div class="col col-lg-2">

            <!-- Button trigger modal -->
            <button type="button" class="btn btn-info btn-lg" data-toggle="modal" data-target="#myModal">
                AddJob
            </button>

            <!-- Modal -->
            <div class="modal fade" id="myModal" role="dialog">
                <div class="modal-dialog modal-sm">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                            <h4 class="modal-title">New job detailes</h4>
                        </div>
                        <div class="modal-body">
                            <form>
                                <div class="form-group">
                                    <label for="formGroupExampleInput">Title</label>
                                    <input type="text" class="form-control" id="formGroupExampleInput" placeholder="Title">
                                </div>
                                <div class="form-group">
                                    <label for="formGroupExampleInput2">Location</label>
                                    <input type="text" class="form-control" id="formGroupExampleInput2" placeholder="Location">
                                </div>
                                <div class="form-group">
                                    <label for="formGroupExampleInput3">Salary</label>
                                    <input type="text" class="form-control" id="formGroupExampleInput3" placeholder="Salary">
                                </div>
                                <div class="form-group">
                                    <label for="formGroupExampleInput4">Description</label>
                                    <textarea class="form-control" id="formGroupExampleInput4" placeholder="Description" rows="3"></textarea>
                                </div>
                            </form>
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-success" data-dismiss="modal" @click="save()">Save</button>
                        </div>
                    </div>
                </div>
            </div>
            
        </div>
    </div>
</template>

<script lang="ts">
import { defineComponent} from 'vue'

export default defineComponent({
    name: 'AddJobModal',
    methods: {
        save()
        {
            console.log("save");
        }
    }
})
</script>

<style scoped>
.modal-header .close {
    margin-left: -50px;
}
</style>