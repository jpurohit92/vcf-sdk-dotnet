# Vcenter.Automation.OpenApi.Model.VcenterEnvironmentBrowserConfigTargetsConfigTargetSpec
ConfigTargetSpec represents the search criteria and filters on a vim.vm.ConfigTarget.    A vim.vm.ConfigTarget has five categories of data:     - Basic: numCpus, numCpuCores, numNumaNodes, smcPresent, maxMemMBOptimalPerf, resourcePool, autoVmotion, maxPersistentMemoryMB    - Datastores: datastore    - Networks: network, opaqueNetwork, distributedVirtualPortgroup, distributedVirtualSwitch, legacyNetworkInfo    - Devices: cdRom, serial, parallel, usb, floppy, scsiPassthrough, pciPassthrough, sriov, vFlashModule, sharedGpuPassthrough, dynamicPassthrough, qat, Intel SGX, AMD-SEV    - Disks: scsiDisk, ideDisk         *GET /vcenter/environment-browser/config-targets* will always return the basic category within a vim.vm.ConfigTarget. For other categories, data is only returned if it is requested via the projection parameter.   Possible values:   - `DATASTORES`: Datastores category includes datastore list within a vim.vm.ConfigTarget.   - `NETWORKS`: Networks category includes network, opaqueNetwork, distributedVirtualPortgroup, distributedVirtualSwitch and legacyNetworkInfo within a vim.vm.ConfigTarget.   - `DEVICES`: Devices category includes cdRom, serial, parallel, sound, usb, floppy, scsiPassthrough, pciPassthrough, sriov, vFlashModule and sharedGpuPassthroughTypes within a vim.vm.ConfigTarget.   - `DISKS`: Disks category includes scsiDisk and ideDisk within a vim.vm.ConfigTarget.   This enumeration was added in __vSphere API 8.0.2.00300__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

