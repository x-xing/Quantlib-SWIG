/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class AssetOrNothingPayoff extends Payoff {
  private transient long swigCPtr;

  protected AssetOrNothingPayoff(long cPtr, boolean cMemoryOwn) {
    super(QuantLibJNI.AssetOrNothingPayoff_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(AssetOrNothingPayoff obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_AssetOrNothingPayoff(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public AssetOrNothingPayoff(Option.Type type, double strike) {
    this(QuantLibJNI.new_AssetOrNothingPayoff(type.swigValue(), strike), true);
  }

}