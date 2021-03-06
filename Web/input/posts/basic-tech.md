Title: Basic Tech
Published: 8/4/2021 11:30 AM
---
## **Floating**

_How to float_

Peach can float at a fixed height for 2.5 seconds (150 frames) while being able to move horizontally. She starts floating by holding down and pressing X or Y at the same time, and then floats for as long as either X/Y is pressed or the control stick is pointing up. She also starts floating when 1 frame after she reaches the peak of her jump or double jump height either X/Y is pressed or the control is pointing up.

_Actions while floating_

Peach can still use all of her aerials and special moves while floating, including throwing turnips with down-B, but the special moves interrupt her float. When Peach starts an aerial, she can float for the whole duration of that aerial, even when that exceeds the normal maximum float time. During the IASA frames of the aerials, Peach can also jump with X/Y and tap jump, and she can Z-drop items. When you drop out of float during a float Dair into Upair combo, that’s likely because holding up for the Upair caused a tap jump. This does not happen when using the C-stick for the aerials.

_How to stop floating_



* The straightforward way is to stop holding X/Y or stop holding up to interrupt the float, which often is fine, but Peach will not be able to fastfall or perform any action other than drifting horizontally for 5 frames.
* The other common method is to start an aerial like nair, and then immediately stop floating and fastfall. Peach can fastfall on frame 2 after releasing float.
* When you have a turnip, throwing the turnip with down-B is another good way to stop floating while also using a projectile.

_Floating after dropping through platforms consumes Peach’s double jump_

When pressing X/Y after dropping or shield dropping through a platform, Peach jumps for one frame, and then floats on the next frame. Peach only doesn’t lose her double jump that way when she falls for an extended duration before floating, but this is not practical (when dropping through the Dreamland top platform, she must almost drop to the ground to float without losing her double jump).

**Float cancel aerials**

When a character lands while doing an aerial attack, they usually go into a special lengthy landing animation. L-cancelling can be used to halve the time of that animation. But Peach can do better: When she floats and starts an aerial while floating, then stops floating during the aerial and lands on the ground, she bypasses the special landing animation and instead only goes into the 4 frame landing animation she would have from landing normally without doing an aerial. This is known as a **float cancel (FC) aerial. **Technically it is enough to start the aerial one frame after releasing the float.

**Linked float cancel aerial (advanced):** When you are already in the falling phase of the FC aerial, and then start another aerial during the IASA frames, this aerial will also be float cancelled and only have 4 frames landing lag. When falling from high enough, even more of these extended FC aerials can be stringed together, but this doesn’t happen in practice. The most useful example is floating above someone and then pressure their shield with a linked FC dair into nair, which is not easy to punish because dair has very little endlag.

**How to perform ground level FC aerials that hit an opponent or their shield**

The basics are always the same: Float, start an aerial that hits something, and fall down to the ground. But we don’t want to waste any time and reach the ground as fast as possible after the hit. We have three ways to minimize our falling time:



1. **Fastfall after the hitlag**, or sometimes even before. This is the most important factor and saves about 5 frames. To fastfall frame perfectly after hitlag, tap the control stick down on the frame where hitlag ends, or 3 frames before, but in any case keep holding down until the frame where hitlag ends. When you want to grab with Z or dash after the aerial, you must stop holding down before the landing lag ends to avoid going into crouch. For followup options like jab, downsmash, shield, shield grab, or another FC aerial, holding down is fine or at least not a big problem.
2. **Start falling before the aerial hits** to be a bit closer to the ground. This saves another 1-2 frames. (Sometimes the spacing is just right so that Peach still falls when the first hitbox frame is active, and hits with a later frame. This can sometimes increase the frame advantage even more, but the spacing is so tight that this only randomly happens, and not so much on purpose. When delaying the hit too much, the weak hitbox might actually connect, which gives considerably less frame advantage.)
3. **Advanced: Use a subfloat or short hop float** to float even closer to the ground. This is hard to do, and doesn’t even always have the most frame advantage (because often Peach will land on the ground without an active hitbox when attempting to release float or fastfall before the hitbox is out, especially in the first floating frames where the ECB is still “frozen” and closer to the ground).


## **Ground level FC aerials on shield - frame data**

Peach’s FC aerial attacks on shield have the highest frame advantage among the whole cast: after doing an (unstale) FC aerial on a shield, Peach can move 1-4 frames faster than the opponent.

_How staleness affects FC aerials on shield_

When the aerial hits the shield, both characters go through the same amount of hitlag frames, then the shielding character additionally goes through shieldstun frames.



* Shorter hitlag: For unstale aerials, hitlag is 7 frames for Nair/Bair and 8 frames for Fair. However for completely stale aerials, hitlag is 5 frames for Nair/Bair/Fair. Hitlag doesn’t affect the frame advantage in theory, but when hitlag is 2 frames shorter, you also must act 2 frames faster to make use of the frame advantage.
* Shorter shieldstun: Shieldstun of unstale Nair/Bair/Fair is 8 frames, and shieldstun for fully stale Nair/Bair/Fair is 5 frames, thus 3 frames shorter. Therefore stale aerials have up to 3 frames less frame advantage than unstale aerials, which often means that the frame advantage is actually negative.

_Frame data table_

The following table lists the frame advantages of unstale FC aerials on shield.

When Peach fast falls too early, she can land on the ground before the hitbox is out, the same thing can happen when just letting go of float too early, and these cases are indicated with ‘-’.

Advanced: During the first 7 float frames, the ECB is closer to the ground because the relative height of the ECB’s bottom vertex is “frozen” to where it was in the last frame of jumpsquat, which is ground height. For normal ground floats the ECB is 2.2 units above ground level during these first 7 frames, for shorthop floats 1.6, and for subfloats 0.0 units. When subfloating or shorthop floating this is actually relevant, because then just letting go of float can make Peach land immediately on the ground, without an active hitbox. In these cases you must wait for the ECB unfreeze before falling down.


<table>
  <tr>
   <td>
   </td>
   <td>Fastfall after hitlag
   </td>
   <td>Release float before hitlag, fastfall after hitlag
   </td>
   <td>Fastfall before hitlag
   </td>
  </tr>
  <tr>
   <td>Nair
   </td>
   <td>+1
   </td>
   <td>+2
   </td>
   <td>+3
   </td>
  </tr>
  <tr>
   <td>sh float Nair
   </td>
   <td>+2
   </td>
   <td>+3
   </td>
   <td>-
   </td>
  </tr>
  <tr>
   <td>subfloat Nair
   </td>
   <td>+2
   </td>
   <td>+4 (must wait for ECB unfreeze)
   </td>
   <td>-
   </td>
  </tr>
  <tr>
   <td>Upair
   </td>
   <td>+2
   </td>
   <td>+4 when released on frame 3 of upair or earlier, otherwise +3
   </td>
   <td>+4, but the fastfall must be on the last possible frame, otherwise Peach lands without a hitbox
   </td>
  </tr>
  <tr>
   <td>sh float Upair
   </td>
   <td>+2
   </td>
   <td>+4 when released on frame 4 of upair or earlier, otherwise +3
   </td>
   <td>+4, but the fastfall must be on the last possible frame, otherwise Peach lands without a hitbox
   </td>
  </tr>
  <tr>
   <td>subfloat Upair
   </td>
   <td>+3
   </td>
   <td>+4 when released on frame 3 or later, but Peach lands without hitbox when released before that
   </td>
   <td>-
   </td>
  </tr>
  <tr>
   <td>Bair
   </td>
   <td>+1
   </td>
   <td>+3 when released on frame 3 of bair or earlier, otherwise +2
   </td>
   <td>+4 with fastfall on frame 5, +3 with fastfall on frame 6. Peach lands without a hitbox when fastfalling earlier.
   </td>
  </tr>
  <tr>
   <td>sh float Bair
   </td>
   <td>+1
   </td>
   <td>+3 when released on frame 5 of upair or earlier, otherwise +2
   </td>
   <td>+4 with fastfall on frame 5, +3 with fastfall on frame 6. Peach lands without a hitbox when fastfalling earlier. (Must wait for ECB unfreeze)
   </td>
  </tr>
  <tr>
   <td>subfloat Bair
   </td>
   <td>+2
   </td>
   <td>+4 when released on frame 3 or later, otherwise +3
<p>
(must wait for ECB unfreeze)
   </td>
   <td>+4, but the fastfall must be on the last possible frame, otherwise Peach lands without a hitbox
   </td>
  </tr>
  <tr>
   <td>Fair
   </td>
   <td>+1
   </td>
   <td>+4 when released on frame 9-10, +4 when released on frame 11 and the 2nd active frame hits, +3 when released on frame 11 or later otherwise
   </td>
   <td>+4 with fastfall on the last frame, otherwise Peach lands without a hitbox
   </td>
  </tr>
</table>



## **Ground level FC aerials on standing & crouching opponents - frame data**

Peach’s aerials except dair deal 11-15%, and the weak hits of nair and bair do 9-10% (unstale). When the opponent is getting hit while crouching, they have 3 frames less hitlag than Peach for the strong hits, and 2 frames for the weak hits and for the 11% hitbox of upair (only for 1-2% attacks the hitlag difference is 1 frame). Assuming the opponent lands immediately from the ASDI down effect, and does not get the horizontal Sakurai angle, they only have 4 frame landing lag, same as Peach. Hence **with CC the opponent has at least 2-3 frames advantage, plus the falling frames Peach needs to reach the ground, which is 0-3 frames**. When the opponent only uses ASDI down to land immediately and does not crouch (which might happen when they are holding down while being in some animation), they have the same hitlag and landing lag, therefore their frame advantage is equal to the number of Peach’s falling frames. So **with ASDI down only, the opponent has 0-3 frames advantage**. See the shield advantage table for the number of falling frames per move: +4 has zero falling frames, +1 has 3 falling frames.

**Instant shield drop FC aerials**

When shield dropping and then floating instantly, Peach can hit someone with and FC aerial and still land on the platform. This is the fastest way to float when Peach is shielding, and is very useful to punish an attack on Peach’s shield. When you don’t float fast enough you can still hit the opponent and then just fall through the platform. To be able to land on the platform after the FC aerial, you must press jump on frame 1-3 after the shield drop, depending on the aerial, then float until you hit and fastfall (Nair/Bair: frame 3, Upair frame 2, Fair: frame 1). The (unstale) aerials are all +3 on shield. They can be +4 when you release float before the hit, but then you have to press jump earlier (Bair: frame 3, Upair: frame 2, Nair/Fair: frame 1).

**Weak FC nair at low percent**

Weak FC nair has a horizontal Sakurai knockback angle at low percent. For example against Fox weak Nair sakurais until 4%, and when he crouches until 21% (with unstale nair), which means that after the hitlag he stays grounded and goes through 6-11 more frames of hitstun. In this case Peach’s frame advantage can be between 0-5 when Peach has zero falling frames after hitlag, but more realistically it’s between -2 and 3 with 2 falling frames. In any case this is not enough to safely downsmash before Fox can shine you. TODO: should we recommend this technique or not?

**Different float heights: groundfloat, midfloat, fullhop float**

**Differnt groundfloat methods: normal, shorthop float, subfloat, hyperfloat**

**Using double jump momentum before a float**
