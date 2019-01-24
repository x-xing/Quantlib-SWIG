/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class KrugerCubic {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected KrugerCubic(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(KrugerCubic obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_KrugerCubic(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public KrugerCubic(Array x, Array y) {
    this(QuantLibJNI.new_KrugerCubic(Array.getCPtr(x), x, Array.getCPtr(y), y), true);
  }

  public double getValue(double x, boolean allowExtrapolation) {
    return QuantLibJNI.KrugerCubic_getValue__SWIG_0(swigCPtr, this, x, allowExtrapolation);
  }

  public double getValue(double x) {
    return QuantLibJNI.KrugerCubic_getValue__SWIG_1(swigCPtr, this, x);
  }

  public double derivative(double x, boolean extrapolate) {
    return QuantLibJNI.KrugerCubic_derivative__SWIG_0(swigCPtr, this, x, extrapolate);
  }

  public double derivative(double x) {
    return QuantLibJNI.KrugerCubic_derivative__SWIG_1(swigCPtr, this, x);
  }

  public double secondDerivative(double x, boolean extrapolate) {
    return QuantLibJNI.KrugerCubic_secondDerivative__SWIG_0(swigCPtr, this, x, extrapolate);
  }

  public double secondDerivative(double x) {
    return QuantLibJNI.KrugerCubic_secondDerivative__SWIG_1(swigCPtr, this, x);
  }

  public double primitive(double x, boolean extrapolate) {
    return QuantLibJNI.KrugerCubic_primitive__SWIG_0(swigCPtr, this, x, extrapolate);
  }

  public double primitive(double x) {
    return QuantLibJNI.KrugerCubic_primitive__SWIG_1(swigCPtr, this, x);
  }

}
