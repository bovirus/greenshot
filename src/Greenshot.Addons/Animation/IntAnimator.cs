// Greenshot - a free and open source screenshot tool
// Copyright (C) 2007-2020 Thomas Braun, Jens Klingen, Robin Krom
// 
// For more information see: http://getgreenshot.org/
// The Greenshot project is hosted on GitHub https://github.com/greenshot/greenshot
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 1 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace Greenshot.Addons.Animation
{
	/// <summary>
	///     Implementation of the IntAnimator
	/// </summary>
	public class IntAnimator : AnimatorBase<int>
	{
        /// <summary>
        /// Create an int animator
        /// </summary>
        /// <param name="first">int to start with</param>
        /// <param name="last">int to end with</param>
        /// <param name="frames">int with the number of frames</param>
        /// <param name="easingType">EasingTypes</param>
        /// <param name="easingMode">EasingModes</param>
		public IntAnimator(int first, int last, int frames, EasingTypes easingType = EasingTypes.Linear, EasingModes easingMode = EasingModes.EaseIn)
			: base(first, last, frames, easingType, easingMode)
		{
		}

        /// <inheritdoc />
        public override int Next()
		{
			if (!NextFrame)
			{
				return Current;
			}
			var easingValue = EasingValue;
			double delta = Last - First;
			Current = First + (int) (easingValue * delta);
			return Current;
		}
	}
}