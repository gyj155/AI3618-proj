# AI3618-proj
虚拟现实课程大作业

## 项目简介
本项目是基于 Unity + XR Interaction Toolkit 开发的虚拟现实交互作业，实现了一个简单的“房间整理模拟系统”。

用户可以通过 VR 手柄（或 XR Device Simulator）与场景中的物体进行交互，并将物品放置到正确的区域完成任务。

---

## 项目内容

- XR 虚拟现实场景搭建
- 物体抓取与放置（XR Grab Interactable）
- 手柄射线交互（XR Ray Interactor）
- 区域检测系统（Trigger Zone）
- 任务进度系统（TaskManager）
- 正确/错误放置判断逻辑
- 任务完成提示
---

## 场景内容

场景中包含以下物体：

- Book（书本）
- Cup（杯子）
- Trash（垃圾）

以及对应目标区域：

- BookZone（书本区域）
- CupZone（杯子区域）
- TrashZone（垃圾区域）

---

## 技术实现

- Unity 2022.3+
- XR Interaction Toolkit 2.6.5
- Input System
- XR Device Simulator
- C# 脚本控制逻辑

脚本：

- `Assets/scripts/TaskManager.cs` —— 任务管理系统
- `Assets/scripts/TargetZone.cs` —— 区域检测逻辑
- `Assets/scripts/ItemObject.cs` —— 物体标识系统

---

## 演示视频
Assets/demo.mp4

---

